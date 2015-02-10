cd %windir%\system32\inetsrv

appcmd delete site /site.name:classical-api
appcmd delete apppool /apppool.name:classical-api

appcmd add site /name:classical-api /id:34 /physicalPath:C:\inetpub\webapps\classical-api\src\Classical-Music-Nancy /bindings:http/*:80:classical-api.ims

appcmd add apppool /name:classical-api
appcmd set config /section:applicationPools /[name='classical-api'].autoStart:true
appcmd set apppool /apppool.name:classical-api /managedRuntimeVersion:v4.0

appcmd set site /site.name:classical-api /[path='/'].applicationPool:classical-api

appcmd start site /site.name:classical-api