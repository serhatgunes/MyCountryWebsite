## Percy with CircleCI

### Step 1: Install eleventy dependencies to generate static site

Firstly we should install clean-css. If we don't we are getting an error when we run the serve.
```bash
$ npm install --save-dev clean-css 
```

Now we can install eleventy. 
```bash
$ npm install -g @11ty/eleventy
```

Last step for eleventy is that running serve.

This command will add all files into _site folder.
```bash
$ npm run serve
```
Our environment will be running now http://localhost:8080

