// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: messages.proto
// Original file comments:
// C:\Users\emanu\.nuget\packages\grpc.tools\1.2.2\tools\windows_x64\protoc.exe -IBenchmark/common --csharp_out Benchmark/common/grpc --grpc_out Benchmark/common/grpc Benchmark/common/messages.proto --plugin=protoc-gen-grpc=C:\Users\emanu\.nuget\packages\grpc.tools\1.2.2\tools\windows_x64\grpc_csharp_plugin.exe
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Benchmark {
  public static partial class Benchmarker
  {
    static readonly string __ServiceName = "benchmark.Benchmarker";

    static readonly grpc::Marshaller<global::Benchmark.BenchmarkRequest> __Marshaller_BenchmarkRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Benchmark.BenchmarkRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Benchmark.BenchmarkReply> __Marshaller_BenchmarkReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Benchmark.BenchmarkReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Benchmark.MemoryRequest> __Marshaller_MemoryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Benchmark.MemoryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Benchmark.MemoryReply> __Marshaller_MemoryReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Benchmark.MemoryReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Benchmark.BenchmarkRequest, global::Benchmark.BenchmarkReply> __Method_runBenchmark = new grpc::Method<global::Benchmark.BenchmarkRequest, global::Benchmark.BenchmarkReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "runBenchmark",
        __Marshaller_BenchmarkRequest,
        __Marshaller_BenchmarkReply);

    static readonly grpc::Method<global::Benchmark.MemoryRequest, global::Benchmark.MemoryReply> __Method_monitorMemory = new grpc::Method<global::Benchmark.MemoryRequest, global::Benchmark.MemoryReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "monitorMemory",
        __Marshaller_MemoryRequest,
        __Marshaller_MemoryReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Benchmark.MessagesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Benchmarker</summary>
    public abstract partial class BenchmarkerBase
    {
      public virtual global::System.Threading.Tasks.Task runBenchmark(global::Benchmark.BenchmarkRequest request, grpc::IServerStreamWriter<global::Benchmark.BenchmarkReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task monitorMemory(global::Benchmark.MemoryRequest request, grpc::IServerStreamWriter<global::Benchmark.MemoryReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Benchmarker</summary>
    public partial class BenchmarkerClient : grpc::ClientBase<BenchmarkerClient>
    {
      /// <summary>Creates a new client for Benchmarker</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BenchmarkerClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Benchmarker that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BenchmarkerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BenchmarkerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BenchmarkerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Benchmark.BenchmarkReply> runBenchmark(global::Benchmark.BenchmarkRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return runBenchmark(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Benchmark.BenchmarkReply> runBenchmark(global::Benchmark.BenchmarkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_runBenchmark, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Benchmark.MemoryReply> monitorMemory(global::Benchmark.MemoryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return monitorMemory(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Benchmark.MemoryReply> monitorMemory(global::Benchmark.MemoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_monitorMemory, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BenchmarkerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BenchmarkerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BenchmarkerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_runBenchmark, serviceImpl.runBenchmark)
          .AddMethod(__Method_monitorMemory, serviceImpl.monitorMemory).Build();
    }

  }
}
#endregion
