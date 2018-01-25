From this project, running for example:

```bash
dotnet run -- proxy edit -h
```

should result in the argument order being:

```bash
spectretest proxy edit <NAME> <PATH>
```

but it's currently showing in reverse.