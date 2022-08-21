Feature: Flight booking
@mytag
Scenario: Open Website Search for rental car
	Given Load the website  and click on car option
	When Nevigate to second page select same drop off
	Then  Enter Hydrabad  in from field 
	And  choose rajiv Gandhi Intl airport from dropdown 
	When Select Pickup date and time
	Then  Select drop date time
	And select car from provider
	And click on view button
	Then click on email quotes
	And provide email and click on send 


Scenario: Open Website Search for flight
	Given load website and click on flight option
	When choose on way flight
	Then choose from and to location
	And choose date 
	And Make sure the second sorting best selected
	When find the nth option having cheapest fare by comparing fares
	Then verify the element is found and displeyed