Feature: Classical Music Walking Skeleton

	In order to sell classical music
	As a music seller
	I want to display recordings of classical works

Scenario: Store and retrieve title of a recording of a Mahler work
	Given a file: {MahlerDiscography.csv} containing classical recording data	
	And I ingest it into the 7digital classical store
	When I request ~/classical/release/{3479488}
	Then I should see as xml
	| release title				| release Id	|
	| Mahler: Symphony No. 1	| 3479488		|