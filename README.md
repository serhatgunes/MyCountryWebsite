## Percy with CircleCI

### Step 1: Install eleventy dependencies to generate static site

You can run this command to install eleventy. 
```bash
$ npm install -g @11ty/eleventy
```
Then you can run your serve with the following command. This command will generate a folder that named _site and will contain all project files.
```bash
$ npm run serve
```
*Note that, While running serve you might be getting an error related to clean-css.
You can install clean-css with the following command and try again to run serve.*
```bash
$ npm install --save-dev clean-css 
```

If everything is okay our environment will be running now http://localhost:8080

### Step 2: CircleCI configurations

When you log in CircleCI with github account you can see your github repositories.You can add one of your project easily.

After adding project CircleCI will be asking operating system and programing language that you want to use and 
it will give you a sample config.yml file. Lets configure this file inside our project.

Create a folder named .circleci and add a file config.yml (so that the filepath be in .circleci/config.yml)

```python
# Ruby CircleCI 2.0 configuration file
#
# Check https://circleci.com/docs/2.0/language-ruby/ for more details
#
version: 2
jobs:
  build:
    docker:
      - image: circleci/ruby:2.4.1-node-browsers

    working_directory: ~/repo

    steps:
      - checkout
      
      - run:
          name: INSTALL DEPENDENCIES
          command: |
            npm install @11ty/eleventy --save-dev
            gem install percy-cli

      - run:
          name: RUN TESTS
          command: |
            npm run build
            percy snapshot _site
```

Push changes.

After pushing we have to provide percy token to CircleCI environment variables. 

In your CircleCI project, go to Project settings > Environment Variables.

Then set PERCY_TOKEN from your Percy project. This token can be found in your Percy project's settings.

We are ready to catch visual changes.




