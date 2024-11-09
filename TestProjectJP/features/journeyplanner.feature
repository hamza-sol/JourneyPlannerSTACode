Feature: journeyplanner

Scenario: JP01 - verify that a valid walking journey can be planned using widget
	Given customer is on tfl home page
	When customer enters 'Leicester Square' in from field and selects to autocomplete the station name
	And customer enters 'Covent Garden' in to field and selects to autocomplete the station name
	And customer selects to plan my journey
	Then following information is displayed in the walking result of journey results:
		| walking speed | distance | duration |
		| Moderate      | 0.4km    | 6mins    |

Scenario: JP02 - verify that a valid cycling journey can be planned using widget
	Given customer is on tfl home page
	When customer enters 'Leicester Square' in from field and selects to autocomplete the station name
	And customer enters 'Covent Garden' in to field and selects to autocomplete the station name
	And customer selects to plan my journey
	Then following information is displayed in the cycling result of journey results:
		| route    | distance | duration |
		| Moderate | 0.4km    | 1mins    |

Scenario: JP03 - validate the journey time for least walking route option
	Given customer is on journey result page for journey from 'Leicester Square' to 'Covent Garden'
	When customer selects to edit preference on journey result page
	And customer selects route with least walking option on journey result preferences
	And customer selects update journey on journey result preferences
	Then journey time is displayed on journey result page

Scenario: JP04 - verify complete access information at covent garden underground station
	Given customer is on journey result page for journey with least walking option from 'Leicester Square' to 'Covent Garden'
	When customer selects view details on first journey result
	Then following access information is displayed for 'Covent Garden Underground Station' on first result of journey result page:
		| Access Information |
		| Up stairs          |
		| Up lift            |
		| Level walkway      |

Scenario: JP05 - verify journey planner provide invalid query when invalid locations are provided
	Given customer is on tfl home page
	When customer enters 'Leicester Square Underground Station' in from field
	And customer enters '''' in to field
	And customer selects to plan my journey
	Then journey planner error message is displayed to customer

Scenario: JP06 - verify journey planner widget shows required field message
	Given customer is on tfl home page
	When customer clicks on plan my journey
	Then following form errors are displayed to customer:
		| Error Message               |
		| The From field is required. |
		| The To field is required.   |

Scenario: JP07 - verify journey planner provide disambiguation results when incomplete locations are provided
	Given customer is on tfl home page
	When customer enters 'Leicester Square Underground Station' in from field
	And customer enters 'Rayners' in to field
	And customer selects to plan my journey
	Then disambiguation information page is displayed to customer