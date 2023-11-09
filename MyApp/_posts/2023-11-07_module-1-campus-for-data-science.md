---
title: ONS Campus for Data Science - Module 1
summary: Key Takeaways from the first module of ONS data science campus
author: Ben Norton
tags: [data science, L&D, git]
image: https://datasciencecampus.ons.gov.uk/wp-content/uploads/sites/10/2017/03/data-science-icons-630x384-2.jpg
---

# Git Command Glossary

It was good to relearn Git. Before it was 50/50 if I merged correctly.

|Command | Purpose |
|:-------|:------|
|`git init`|initialises a git repo in your current directory|
|`git add <file name>`|adds a specific file to be tracked by git and any changes made|
|`git add .`|adds all untracked files and changes made|
|`git status`|informs you whether changes have been made to the repo (new, untracked, deleted or renamed files)|
|`git commit`|commits all changes / new files added|
|`git commit -m "your message here"`|commits all changes / new files with a user defined message|
|`git checkout <branch name>`|moves to the specified repo, it must exist beforehand|
|`git checkout -b <branch name>`|creates an new branch with a specified name and moves to it|
|`git merge <source branch> <target branch>	`|attempts to merge the source branch with the target branch, you must be on the target branch to do this|
|`git branch -d <branch name>`|deletes the branch if it has been merged|
|`git branch -D <branch name>`|deletes branch regardless of if it has been merged|
|`git fetch`|	retrieve all tracking information about the remote repo|
|`git pull <remote name> <branch name>`|merges the remote branch down to the local branch|
|`git push <remote name> <branch name>`|merges the local branch up to the remote branch|

