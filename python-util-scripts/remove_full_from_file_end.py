import os

def remove_full_suffix(directory="."):
    """
    Removes "_full" suffix from the filenames of all PNG files in the specified directory.
    
    Args:
        directory (str): The directory containing the PNG files. Defaults to the current directory.
    """
    for filename in os.listdir(directory):
        if filename.endswith("_full.png"):
            new_filename = filename.replace("_full.png", ".png")
            os.rename(os.path.join(directory, filename), os.path.join(directory, new_filename))
            print(f"Renamed {filename} to {new_filename}")

# Example usage
remove_full_suffix()
