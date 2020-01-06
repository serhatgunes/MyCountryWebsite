## Percy with CircleCI

### Step 1: Install eleventy dependencies to generate static site

Firstly we should install clean-css. If we don't we are getting an error when we run the serve.
```bash
$ npm install --save-dev clean-css 
```

Now we can install eleventy. 
```bash
npm install -g @11ty/eleventy
```

Last step for eleventy is that running serve.

This command will add all html,css and js files into _site folder.

Our environment will be running now http://localhost:8080
```bash
npm run serve
```




















If you haven’t already, sign up for a free Percy account, name your organization, and create your first project.
```bash
$ git clone https://github.com/serhatgunes/ToDoApplication.git
$ cd ToDoApplication/
```

To install dependencies, compile and run the Todo app:

Note : If you don't have Node.js on your computer you can get from this link
https://nodejs.org/en/download/

```bash
$ npm install
$ npm start
```
You can now visit http://localhost:10001

```bash
$ npm install -D @percy/script
```
This will add @percy/script to your package.json file.

### Step 2: Run Visual Tests

To run your PercyScript locally, copy the PERCY_TOKEN environment variable from the new project screen or your project settings, then run:

```bash
$ export PERCY_TOKEN=aaabbbcccdddeee
$ npx percy exec -- node snapshots.js
```

### Step 3: Review Visual Changes

Change anything to your UI

Now run the snapshots again:

```bash
$ npx percy exec -- node snapshots.js
```

**You’ve done your first visual review!**

