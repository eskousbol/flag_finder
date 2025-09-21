# flag_finder

Project for taking in a given image of a flag and determining what the flag denotes, created as a means of familiarizing myself with C#.

## Step 1: Training a Model

Objective: Train a model using TensorFlow to identify the origin of a given image of a flag.

### Substeps
1. Locate a datasource
 - Decided to use the dataset located here[https://github.com/amckenna41/iso3166-2], as it is allegedly kept up to date, and contains regional flags as well as country flags.
 - This is a Python library, but thankfully the maintainers have made an API available as well, which I am hopeful will be useable in this project.
2. Load the data source