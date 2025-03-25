import subprocess
import time

def run_tests(n=10):
    total_time = 0
    log_file = "sequential_testing.txt"
    
    with open(log_file, "w") as log:
        for i in range(1, n + 1):
            print(f"Running pytest iteration {i}/{n}...")
            start_time = time.time()
            
            result = subprocess.run(["python3", "-m", "pytest", "tests"], 
                                   stdout=subprocess.PIPE, stderr=subprocess.STDOUT, text=True)
            
            end_time = time.time()
            elapsed_time = end_time - start_time
            total_time += elapsed_time
            
            log.write(f"\nIteration {i}:\n")
            log.write(result.stdout)
            log.write(f"Execution Time: {elapsed_time:.2f} seconds\n")
            log.write("="*50 + "\n")
            
    avg_time = total_time / n
    # print(f"Average execution time: {avg_time:.2f} seconds")
    return avg_time

def repeat(n=5):
    print("-"*50)
    sum = 0
    for i in range(n):
        print(f"Repetition {i+1}:")
        sum+= run_tests(3)
        print("-"*50)
    avg_time = sum/5
    print(f"Avergage Execution Time: {avg_time:.2f} seconds\n")
    
    
if __name__ == "__main__":
    repeat()
