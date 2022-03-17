How We Code
============

## Test First

When creating new code, we always write our tests before our code.
  1. Create the test. Use the simplest possible assertion.
	2. Comment out the assertion & commit.
	3. Uncomment the assertion, make it pass, and commit.
	4. Extend the test to a more complicated version of the commit & go to step 2, until this test is done.
	5. Go on to the next behavior.

When fixing a bug, we do the following:
  1. Write a test for the current (buggy) behavior.
	2. Narrow the test until it captures exactly the one change we want to make (verify the cause).
	3. Refactor until we can fix the cause with a 1-line (or close) change.
	4. Make one commit that modifies both the test and the code to match the new behavior.

When modifying existing code we:
  * Separate all behavior-changing commits from behavior-mantaining ones.
	* Use the test-first approach for each new behavior.
	* Use the bug-fix behavior when intentionally changing an existing behavior (we may already have a narrow test, os can start at step 3).
	* Use disciplined refactoring when maintaining behavior.

## Test as Spec



## Organize Tests Into Namespaces



## Use Team-shared `.editorconfig` and R# Settings


