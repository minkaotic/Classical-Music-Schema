Feature: ~/release/{id} endpoint

	In order to sell classical music
	As a music seller
	I want to display releases of classical music recordings

Scenario: Retrieve title of a release
	Given a release exists in the database
	When I request the release from the endpoint
	Then I should see its release title
	