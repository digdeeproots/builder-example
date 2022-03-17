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

Our test is our spec and our design. The tests serve multiple audiences, which we will simplify into two:

  * Product-focused: people who care about implementation details (devs, testers, etc).
	* Purpose-focused: People who don't care about implementation details (customers, managers, sales, cust support, etc).

We assume that both audiences care about what the system should accomplish and why. However, only one audience cares about internal details and transitional states.

Therefore we divide our tests into two categories, represented as namespaces:

  * `Tests.Spec`: tests that verify that the product meets its purposes - anything that purpose-focused people care about.
	* `Tests.Details`: tests that verify anything else.
	* We also provide a namespace `Tests.TestSupport`, which contains abstractions used to simplify the tests, such as custom assertions.

Every test assembly uses these namespaces. Specifically, they all share the `Tests` namespace as their default namespace.

We treat our test classes as a representation of the spec. We actually generate a spec document from them, but the relationship is also metaphorical.

  * Within these top-level categories, tests are organized into nested sub-namespaces.
	* The names of these namespaces are intended to be like the headers of a spec - they define an area of concern, not an area of implementation in the product code.
	* The class name is the lowest-level header.
	* The test method name is the topic sentence for the spec paragraph.
	* The method body maps the topic sentence to the code - it shows how the product implements that statement.
	* The class comment provides additional spec elaboration. This can be used for regulatory requirements (such as security analysis) and describing customer context.

## Use Team-shared `.editorconfig` and R# Settings


