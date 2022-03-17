How We Use Source Control
=========================

## Use Arlo's Commit Notation

We use [Arlo's Commit Notation](https://github.com/RefactoringCombos/ArlosCommitNotation) to communicate risk on a per-commit basis. In addition to the base intentions, we use the following [extended intentions](https://github.com/RefactoringCombos/ArlosCommitNotation/blob/main/Extension%20Intentions.md):

  * `T` = Test-only
	* `E` = Environment
	* `A` = Auto
	* `P` = Process
	* `S` = Spec

We do not use `M` (Merge). Instead we mark the PR merge commit with the correct intention code for the purpose of that movement. We attempt to avoid merges from main to a branch by limiting the duration of any branch to a short period of time. That allows it to be rebased onto main instead of merged, giving us a semi-linear history.

## Use Trunk-based Development

We use trunk-based development with PRs. This means:

  * All changes are made on a short-lived feature branch.
  * Feature branches come off of the trunk and are merged back to the trunk exactly once.
	* Prefer to avoid merges from trunk to a feature branch. Prefer to rebase the feature branch onto the head of main when possible.
	* Feature branches shall be short-lived. Generally keep them less than 1 day.
	* The merge back to the trunk is done via a Pull Request (PR).

## Use Our Standard Branch Prefixes

