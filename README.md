From this project, running for example:

```bash
dotnet run -- proxy edit -h
```

should result in the help including `<PATH>` (from `SharedCommandSettings`) but this isn't the case.

Very strangely if you change the structure from:

```
SharedCommandSettings
    |
    v
CreateCommandSettings
```

to this insteadL

```
ProxyCommandSettings <- update Program.cs (this can be empty)
    |
    v
SharedCommandSettings <- Keep the argument here
    |
    v
CreateCommandSettings
```

the arguments magically show up in help again