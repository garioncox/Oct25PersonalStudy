Feature: CSV Reader

@datasource:small_dataset.csv
Scenario: The smaller data set is read correctly
	Given the dataset "..\..\..\small_dataset.csv"
	And the data is successfully read
	Then the label should be <label>
	Then first datapoint should be <d1>
	Then second datapoint should be <d2>
	Then third datapoint should be <d3>
	Then fourth datapoint should be <d4>
Examples: 
	| label | d1 | d2 | d3 | d4 |
	| 1     | 2  | 3  | 4  | 5  |
	| 6     | 7  | 8  | 9  | 0  |
	| 4     | 5  | 6  | 7  | 8  |
	| 1     | 4  | 6  | 8  | 0  |
	| 8     | 6  | 4  | 1  | 6  |
	| 7     | 7  | 7  | 7  | 7  |
	| 1     | 3  | 6  | 1  | 3  |