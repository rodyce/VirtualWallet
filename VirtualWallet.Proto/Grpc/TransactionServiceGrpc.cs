// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: proto_defs/grpc/TransactionService.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace VirtualWallet.Proto.Grpc {
  public static partial class TransactionService
  {
    static readonly string __ServiceName = "VirtualWallet.Proto.Grpc.TransactionService";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VirtualWallet.Proto.Messages.Transaction> __Marshaller_Transaction = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VirtualWallet.Proto.Messages.Transaction.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VirtualWallet.Proto.Grpc.TopUpRequest> __Marshaller_TopUpRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VirtualWallet.Proto.Grpc.TopUpRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VirtualWallet.Proto.Grpc.TransferRequest> __Marshaller_TransferRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VirtualWallet.Proto.Grpc.TransferRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VirtualWallet.Proto.Grpc.PurchaseRequest> __Marshaller_PurchaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VirtualWallet.Proto.Grpc.PurchaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::VirtualWallet.Proto.Grpc.TransactionId> __Marshaller_TransactionId = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::VirtualWallet.Proto.Grpc.TransactionId.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::VirtualWallet.Proto.Messages.Transaction> __Method_GetAllTransactions = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::VirtualWallet.Proto.Messages.Transaction>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllTransactions",
        __Marshaller_Empty,
        __Marshaller_Transaction);

    static readonly grpc::Method<global::VirtualWallet.Proto.Grpc.TopUpRequest, global::VirtualWallet.Proto.Messages.Transaction> __Method_NewTopUp = new grpc::Method<global::VirtualWallet.Proto.Grpc.TopUpRequest, global::VirtualWallet.Proto.Messages.Transaction>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewTopUp",
        __Marshaller_TopUpRequest,
        __Marshaller_Transaction);

    static readonly grpc::Method<global::VirtualWallet.Proto.Grpc.TransferRequest, global::VirtualWallet.Proto.Messages.Transaction> __Method_NewTransfer = new grpc::Method<global::VirtualWallet.Proto.Grpc.TransferRequest, global::VirtualWallet.Proto.Messages.Transaction>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewTransfer",
        __Marshaller_TransferRequest,
        __Marshaller_Transaction);

    static readonly grpc::Method<global::VirtualWallet.Proto.Grpc.PurchaseRequest, global::VirtualWallet.Proto.Messages.Transaction> __Method_NewPurchase = new grpc::Method<global::VirtualWallet.Proto.Grpc.PurchaseRequest, global::VirtualWallet.Proto.Messages.Transaction>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewPurchase",
        __Marshaller_PurchaseRequest,
        __Marshaller_Transaction);

    static readonly grpc::Method<global::VirtualWallet.Proto.Grpc.TransactionId, global::VirtualWallet.Proto.Messages.Transaction> __Method_ViewTransaction = new grpc::Method<global::VirtualWallet.Proto.Grpc.TransactionId, global::VirtualWallet.Proto.Messages.Transaction>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ViewTransaction",
        __Marshaller_TransactionId,
        __Marshaller_Transaction);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::VirtualWallet.Proto.Grpc.TransactionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TransactionService</summary>
    public abstract partial class TransactionServiceBase
    {
      public virtual global::System.Threading.Tasks.Task GetAllTransactions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::VirtualWallet.Proto.Messages.Transaction> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::VirtualWallet.Proto.Messages.Transaction> NewTopUp(global::VirtualWallet.Proto.Grpc.TopUpRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::VirtualWallet.Proto.Messages.Transaction> NewTransfer(global::VirtualWallet.Proto.Grpc.TransferRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::VirtualWallet.Proto.Messages.Transaction> NewPurchase(global::VirtualWallet.Proto.Grpc.PurchaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ViewTransaction(global::VirtualWallet.Proto.Grpc.TransactionId request, grpc::IServerStreamWriter<global::VirtualWallet.Proto.Messages.Transaction> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TransactionService</summary>
    public partial class TransactionServiceClient : grpc::ClientBase<TransactionServiceClient>
    {
      /// <summary>Creates a new client for TransactionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TransactionServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TransactionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TransactionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TransactionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TransactionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::VirtualWallet.Proto.Messages.Transaction> GetAllTransactions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllTransactions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::VirtualWallet.Proto.Messages.Transaction> GetAllTransactions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllTransactions, null, options, request);
      }
      public virtual global::VirtualWallet.Proto.Messages.Transaction NewTopUp(global::VirtualWallet.Proto.Grpc.TopUpRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return NewTopUp(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VirtualWallet.Proto.Messages.Transaction NewTopUp(global::VirtualWallet.Proto.Grpc.TopUpRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NewTopUp, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VirtualWallet.Proto.Messages.Transaction> NewTopUpAsync(global::VirtualWallet.Proto.Grpc.TopUpRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return NewTopUpAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VirtualWallet.Proto.Messages.Transaction> NewTopUpAsync(global::VirtualWallet.Proto.Grpc.TopUpRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NewTopUp, null, options, request);
      }
      public virtual global::VirtualWallet.Proto.Messages.Transaction NewTransfer(global::VirtualWallet.Proto.Grpc.TransferRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return NewTransfer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VirtualWallet.Proto.Messages.Transaction NewTransfer(global::VirtualWallet.Proto.Grpc.TransferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NewTransfer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VirtualWallet.Proto.Messages.Transaction> NewTransferAsync(global::VirtualWallet.Proto.Grpc.TransferRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return NewTransferAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VirtualWallet.Proto.Messages.Transaction> NewTransferAsync(global::VirtualWallet.Proto.Grpc.TransferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NewTransfer, null, options, request);
      }
      public virtual global::VirtualWallet.Proto.Messages.Transaction NewPurchase(global::VirtualWallet.Proto.Grpc.PurchaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return NewPurchase(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::VirtualWallet.Proto.Messages.Transaction NewPurchase(global::VirtualWallet.Proto.Grpc.PurchaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NewPurchase, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::VirtualWallet.Proto.Messages.Transaction> NewPurchaseAsync(global::VirtualWallet.Proto.Grpc.PurchaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return NewPurchaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::VirtualWallet.Proto.Messages.Transaction> NewPurchaseAsync(global::VirtualWallet.Proto.Grpc.PurchaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NewPurchase, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::VirtualWallet.Proto.Messages.Transaction> ViewTransaction(global::VirtualWallet.Proto.Grpc.TransactionId request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ViewTransaction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::VirtualWallet.Proto.Messages.Transaction> ViewTransaction(global::VirtualWallet.Proto.Grpc.TransactionId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ViewTransaction, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TransactionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TransactionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TransactionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllTransactions, serviceImpl.GetAllTransactions)
          .AddMethod(__Method_NewTopUp, serviceImpl.NewTopUp)
          .AddMethod(__Method_NewTransfer, serviceImpl.NewTransfer)
          .AddMethod(__Method_NewPurchase, serviceImpl.NewPurchase)
          .AddMethod(__Method_ViewTransaction, serviceImpl.ViewTransaction).Build();
    }

  }
}
#endregion
