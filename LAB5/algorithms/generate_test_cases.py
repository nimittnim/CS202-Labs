import os
import subprocess

# Root folder where all algorithm modules are stored
ROOT_FOLDER = "algorithms"

def generate_tests():
    for root, _, files in os.walk(ROOT_FOLDER):
        for file in files:
            if file.endswith(".py"):
                # Convert file path to module name
                module_path = os.path.join(root, file).replace("/", ".").replace("\\", ".").replace(".py", "")
                
                # Run Pynguin command
                print(f"Generating tests for: {module_path}")
                subprocess.run(["pynguin", "--project-path", ".", "--module-name", 
                module_path, "--output-path","./pynguin_tests",
                "--maximum_search_time","30"])

if __name__ == "__main__":
    generate_tests()