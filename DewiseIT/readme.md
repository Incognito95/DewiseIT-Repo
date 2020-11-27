## The task is as follows: 

* Create code that downloads the following compressed .ndjson file to your own local file system (Temp folder): https://files.pushshift.io/twitter/TU_verified.ndjson.xz

* Unpack it (still via code)
* Load it line by line so that it does not fill the memory in your CLR (tip: lazy) - Done
* Get number of current followers per. twitter account online - Done
* Save a file there per. line shows twitter account handle and the difference between twitter followers in the file and online (followers diff) - done
* Return the total followers diff (a single number) as a result of your function - Done