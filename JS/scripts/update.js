const fs = require('fs');
const { execSync } = require('child_process');

const dirExists = (path) => {
  try {
    return fs.statSync(path).isDirectory();
  } catch (err) {
    return false;
  }
};

const run = (command, args) => {
  console.log(`Running: ${command} ${args.join(' ')}`);
  execSync(`${command} ${args.join(' ')}`, { stdio: 'inherit' });
};

const update = () => {
  fs.rmSync('./package-lock.json', { force: true });

  if (dirExists('./node_modules')) {
    console.log('Cleaning node_modules...');
    run('npm', ['cache', 'clean', '--force']);
    fs.rmSync('./node_modules', { recursive: true, force: true });
  }

  console.log('Updating and saving dependencies to package.json...');
  run('npm', ['update', '--save']);

  console.log('Installing dependencies...');
  run('npm', ['install']);

  console.log('Update completed successfully!');
};

update();
