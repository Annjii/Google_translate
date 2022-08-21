Feature: OralBWebsite OralB Application for Verifying text

@mytag
Scenario: Oralb
	Given Load the OralB Website
	When You click on Kid's brushes from Dropdown
	Then Verify the text Kids is displayed

@mytag1
Scenario Outline: oralb2
	Given Load the  Website
	When Click on Search Icon on top Corner
	And Search "<item>" in searchbox 
	And Select First link 
	Then Verify the text BATTERY is displayed
Examples: 
| item    |
| Battery |

@mytag2
Scenario Outline: oralb3
	Given Load the Webpage
	When Click on Floss Under Shop in footer 
	Then Verify FLOSS PICKS appearing in the list products


