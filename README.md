# VirtualWallet
A simple wallet with money transaction operations among people.

## Protocol Buffers and gRPC file generation

In order to generate them in C#, use the the **--csharp_out** and **--grpc_out** command line arguments of the **protoc** compiler. You also need to have the **protoc-gen-rpc plugin for C#** which is downloaded along with the **Grpc.Tools Nuget package**. For this project, **protoc v3.3.0** is being used and the **Grpc.Tools v1.4.x** Nuget package.

Consider the following example. The downloaded Nuget packages are in the user's home directory. The gRPC and message definitions are in the **proto_defs/grpc** and **proto_defs/messages** directories respectively and relative to the project's parent directory. The output directory for the gRPC service definitions and messages are **Proto/Grpc** and **Proto/Messages** respectively. This is to match the C# namespaces with the directory location of the files.

The command line to generate the files, invoked from the project's parent directory are as follows:

- **gRPC services generation**

```bash
$ protoc --csharp_out=Proto/Grpc --grpc_out=Proto/Grpc --plugin=protoc-gen-grpc=${HOME}/.nuget/packages/grpc.tools/1.4.1/tools/${PLATFORM}/grpc_csharp_plugin proto_defs/grpc/*.proto
```

- **Protocol Buffers message generation**
```bash
$ protoc --csharp_out=Proto/Messages proto_defs/messages/*.proto
```

Where ${PLATFORM} may be one of the following:

```bash
$ ls ${HOME}/.nuget/packages/grpc.tools/1.4.1/tools/

linux_x64  linux_x86  macosx_x64  macosx_x86  windows_x64  windows_x86
```
