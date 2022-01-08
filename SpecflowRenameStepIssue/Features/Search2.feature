Feature: Google Search Test 2

A short summary of the feature

Scenario Outline: Search test 3
	Given I am on google home page
	When I enter text "<SearchTerm>"
	And I select search button
	Then I should see resluts page

	Examples: 
	| TestNo | SearchTerm |
	| 00001  | apple      |
	| 00002  | banana     |