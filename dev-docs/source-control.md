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

We use the following branch name prefixes to indicate the purpose of each feature branch.

  * `features/`: changes which impact the product, including build environment, dev tooling or the like. Generally any code change is in such a branch.
	* `probably-wrong/`: exploring directions that are likely wrong. These allow us to explore alternatives without worrying about them getting into the product. A `probably-wrong` branch cannot be merged into main, though it can later be renamed to a feature branch.
	* `spikes/`: a durable exploration and example of something. Use these to explore an idea, then clean it up and leave that as an example for others. These are not product code and cannot be merged into main.
	* `process/`: a change in our processes / working agreements. Anyone can create such a branch at any time; that constitutes a proposal. The PR is our chance to discuss the proposal. A proposal is accepted when the branch is merged into main. A rejected proposal can be deleted or left, as the author sees fit.
	* `spec/`: a change in the spec only. Spec changes can also happen in `features/` branches. Naming a branch `spec/` simply provides clarity that the changes only constitute a proposed change to the spec; they do not include code to meet that new spec. Like a `process/` branch, PR is used to discuss the spec and approval consists of merging onto main.
