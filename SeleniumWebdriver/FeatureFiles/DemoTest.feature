Feature: Login 

@login
Scenario Outline: Login correct credentials
	Given the LoginPage is open
    And  the page "header" message is present
    When the user fills in the "<username>" and "<password>".
    Then the user clicks the login button
    Given the "home page" is open
    Examples: 
      | TestCase | username                     | password     |
      | A        | standard_user                | secret_sauce |
      | B        | locked_out_user              | secret_sauce |
      | C        | problem_user                 | secret_sauce |
      | D        | performance_glitch_user      | secret_sauce |


@login
Scenario Outline: Login incorrect credentials
	Given the "LoginPage" is open
    And  the page "header" message is present
    When the user fills in their "<username>" and "<password>".
    Then the user clicks the "login button"
    And the "error" message is displayed
    Examples:
    | TestCase                                          | username       |     password       |
    | Correct username & incorrect password             | standard_user  |  secret_sauce1     |
    | Incorrect username & incorrect password           | standard_user1 |  secret_sauce1     |
    | Incorrect username & correct password             | standard_user1 |  secret_sauce      |
   








