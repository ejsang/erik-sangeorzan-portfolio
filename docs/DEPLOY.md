# Deploying this portfolio (GitHub Pages — MkDocs)

This repo contains a GitHub Actions workflow that builds the MkDocs site and deploys to the `gh-pages` branch automatically on push to `main` or `master`.

Quick checklist
1. Create a new GitHub repository (e.g., `eriksangeorzan-portfolio`) and push the `my-portfolio` folder to it (or push this repo as-is).
2. Ensure the default branch is `main` (or `master`); the workflow triggers on pushes to that branch.
3. Enable GitHub Actions in the repository (usually enabled by default). The workflow file is `.github/workflows/deploy.yml`.
4. After the first successful run, the site is published on the `gh-pages` branch. You can configure the repository's Pages settings to use the `gh-pages` branch and the `/` root (or leave Actions to manage it automatically).

Notes
- The workflow uses `GITHUB_TOKEN` automatically (no extra secret needed).
- If you prefer Netlify or Vercel, you can connect the repository there and set the build command to `mkdocs build` and publish the contents of the `site/` directory.