# Windmill
An interpreted binary executor for CosmosOS.  
###  !! This project is no longer active due too it being redundant. !!

TODO:
- Parsing methods - only byte & int32 to string atm;
- If statements;
- Goto function;
- Memory shifting/gc;
- *Multitasking*;

Note: The current project files are made for a normal CLI C# application, but they can easily be ported over to CosmosOS.

## Building for linux
To build Windmill for linux you need to install ``mono`` from [here](https://www.mono-project.com/download/stable/#download-lin).

After installing ``mono`` change the permissions of ``build-linux.sh`` to executable with the following command:
```
chmod +x build-linux.sh
```
and execute the file with
```
./build-linux.sh
```
