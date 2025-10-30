$maxRetries = 3
$attempt = 0
$success = $false
while ($attempt -lt $maxRetries -and -not $success) {
    $attempt++
    Write-Host "License activation attempt $attempt..."
    $output = & "C:\ProgramData\GrapeCity\gclm\gclm.exe" 4327eaf8-aa02-40a6-b9f6-3d007c039055 -a $env:LICENSE_KEY | Out-String
    Write-Host $output
    if ($output -match "Activation completed.") {
        Write-Host "License activated successfully."
        $success = $true
    } else {
        Write-Host "Activation failed. Retrying..."
        Start-Sleep -Seconds 5
    }
}
if (-not $success) {
    Write-Error "License activation failed after $maxRetries attempts."
    exit 1
}