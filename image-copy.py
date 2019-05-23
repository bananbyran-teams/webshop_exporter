import sys
import os, os.path
import shutil

if len(sys.argv) < 3:
    print("Using: image-copy.py <base-path> <filelist-path>")
    sys.exit(1)

with open(sys.argv[2]) as filelist:
    for filename in filelist:
        (name, _) = filename.split(".")
        partParts = list(name)
        partParts.append(filename.rstrip())
        sourcePath = os.path.join(sys.argv[1], *partParts)
        
        try:
            shutil.copyfile(sourcePath, filename.rstrip())
        except:
            print ("Failed to copy " + filename.rstrip())

        