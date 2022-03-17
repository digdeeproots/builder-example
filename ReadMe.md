Builders Example
===============

Sample code that shows several ways to make tests obvious, especially by using builders. It also shows the use of builders in production code. This code demonstrates all of the following:

* Working in short movements made up of tiny commits.
* Using Arlo's Commit Notation to make risk obvious.
* How to accomplish some common design changes as a sequence of R# refactorings with no hand edits.
* The use of builders to make test data easy.
* The use of builders to adapt an overly-general API and simplify production code.
* Using custom test assertions to make intention obvious.
* Use of Culture as Code to make process changes easier to propose and easier to spread.
* Test as Spec - use of acceptance micro-tests to verify the code and communicate with stakeholders.
* Spect and change control generation based on source control history.

The end result is a coding style that results in fluid, rapid programming, yet still can be used in regulated environments to ease approval.

## How to Change Processes

All process agreements are made by pull request. Anyone may create a process proposal PR at any time. Acceptance (and merging) of the PR indicates acceptance of the proposal into the project.

A process proposal consists of the following:

* A branch with the name `process/[name-of-process]/[proposed-change]`.
* Commits on that branch that modify this document or others linked from it, describing the proposed new way. The diff serves as the description of the change to get from our current process to the new one.
* Risk codes in commit messages on a process branch shall refer to the risk entailed in adopting the portion of the process described in that commit.
* A PR of that branch that includes all project leadership.

Process review and agreement then follows the standard PR process. Generally, the project leadership will only approve the PR once Consent is achieved. PR comments are the preferred communications medium for discussing the change, so that the entire conversation is public.

## How We Do Things

We currently agree to the following ways of working.

* [How We Use Source Control](dev-docs/source-control.md)
  * Use Arlo's Commit Notation
	* Use Trunk-based Development
  * Use Our Standard Branch Prefixes
* [How We Code](dev-docs/coding.md)
  * Test First
	* Test as Spec
	* Organize Tests Into Namespaces
	* Use Team-shared `.editorconfig` and R# Settings
* [How We Build and Test](dev-docs/building.md)
  * How to Build & Test
	* How to Generate the Spec
