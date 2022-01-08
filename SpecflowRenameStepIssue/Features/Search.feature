Feature: Google Search Test 1

A short summary of the feature

# ISSUE 57
@tag1
Scenario: Search test 1
	Given I am on google home page
	When I enter text "test" 
	And I select search button
	Then I should see resluts page

Scenario: Search test 2
	Given I am on google home page
	When I enter text "new test"
	And I select search button
	Then I should see resluts page

	Scenario: Search test 3
	Given I am on google home page
	When I enter text "new test"
	And I select search button
	Then I should see resluts page contains "fail this test"
