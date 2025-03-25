import subprocess
import time
import itertools
import os

# Parallel configurations to test
worker_levels = ["1", "auto"]  # Process-level parallelization
thread_levels = ["1", "auto"]  # Thread-level parallelization
xdist_modes = ["load", "no"]   # Pytest-xdist distribution modes

# Directory to store logs
log_dir = "test_logs"
os.makedirs(log_dir, exist_ok=True)

# Summary file
summary_file = os.path.join(log_dir, "parallel_test_results.txt")

def run_tests(worker, thread, dist_mode, run_id):
    """Runs pytest with the given parallel settings and saves output to a log file."""
    log_filename = os.path.join(log_dir, f"test_log_w{worker}_t{thread}_d{dist_mode}_run{run_id}.txt")
    
    cmd = [
        "python3 -m pytest",
        f"-n {worker}",
        f"--dist {dist_mode}",
        f"--parallel-threads {thread}"
    ]
    
    start_time = time.time()
    with open(log_filename, "w") as log_file:
        result = subprocess.run(" ".join(cmd), shell=True, stdout=log_file, stderr=log_file, text=True)
    end_time = time.time()
    
    execution_time = end_time - start_time

    # Extract failed tests from log file
    with open(log_filename, "r") as log_file:
        output = log_file.readlines()
    
    failures = [line.strip() for line in output if "FAILED" in line]

    return execution_time, failures, log_filename

# Run tests with all configurations and log results
with open(summary_file, "w") as summary:
    summary.write("Worker, Thread, Dist Mode, Execution Time (s), Failed Tests\n")
    
    for worker, thread, dist_mode in itertools.product(worker_levels, thread_levels, xdist_modes):
        times = []
        all_failures = []
        log_files = []
        
        for run_id in range(3):  # Run each configuration 3 times
            exec_time, failures, log_filename = run_tests(worker, thread, dist_mode, run_id)
            times.append(exec_time)
            all_failures.extend(failures)
            log_files.append(log_filename)
        
        avg_time = sum(times) / len(times)
        unique_failures = set(all_failures)
        
        summary.write(f"{worker}, {thread}, {dist_mode}, {avg_time:.2f}, {len(unique_failures)}\n")
        print(f"Executed: Worker={worker}, Thread={thread}, Dist={dist_mode}, Avg Time={avg_time:.2f}s, Failures={len(unique_failures)}")

print(f"\nSummary stored in {summary_file}. Detailed logs are in {log_dir}/")
