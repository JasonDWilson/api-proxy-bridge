# api-proxy-bridge:  A C# proxy wrapper for the Bridge Learning Management System LMS

*Please note that this is not intended to be a comprehensive coverage of the Bridge API
I only included what I needed when I wrote it.*

### If there are things you need feel free to contribute

Usage:
- All usage is governed through the DataManager class
- DataManager expects a BridgeApiConfiguration object to be injected that contains url and credentials for the API

```
var dm = new DataManager(new BridgeApiConfiguration{ key = <your key>, url = <your url> });
var courses = dm.GetCourseTemplates(1000,"My Course");
```

*please let me know if you have questions*



"# api-proxy-bridge" 
