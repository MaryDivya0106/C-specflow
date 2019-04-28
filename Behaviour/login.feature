Feature: login
	Scenario Outline: login to the facebook portal
	Given i have launched the browser.
	And i have given url.
	When I entered "<username>", "<password>" and clicked login button.
	Then i have navigated to facebook home page.
	Examples:
	         |username					|password|
	         | bereddydivya@gmail.com   | Divyareddy0106 |
	         | divyareddy0106@gmail.com | mary1234      |
	         | divya@gmail.com          | divz12345     |