# Docker image setup
$User = "reecerose"
$ProjectName = "dockerexample"
$Tag = "build"
$Version = 1.0

$Target = "{0}/{1}:{2}-{3}" -f $User, $ProjectName, $Version, $Tag

Set-Location .\DockerExample\
# Delete a previous image of this version
docker rmi $Target -f
# Build new image
docker build -t $Target .
Set-Location ../