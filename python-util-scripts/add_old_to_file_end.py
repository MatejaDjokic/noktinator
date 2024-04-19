import os


def rename_png_files():
    current_folder = os.getcwd()
    for filename in os.listdir(current_folder):
        if filename.endswith(".png"):
            new_filename = filename[:-4] + "_old.png"
            os.rename(os.path.join(current_folder, filename),
                      os.path.join(current_folder, new_filename))
            print(f"Renamed {filename} to {new_filename}")


rename_png_files()
