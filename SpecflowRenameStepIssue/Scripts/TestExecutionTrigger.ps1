
$source = "$PSScriptRoot"
$parent = Split-Path -Path $source -Parent
$timeStamp = Get-Date -Format "ddmmyyyyHHMMSS"
cd $parent
dotnet test SpecflowRenameStepIssue.dll -v n --logger "trx;logfilename=TestResults.trx"
livingdoc test-assembly SpecflowRenameStepIssue.dll -t TestExecution.json --output TestResults\TestExecutionReport-$timeStamp.html --title "Sample Test Execution Report"