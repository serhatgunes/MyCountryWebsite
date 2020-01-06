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

