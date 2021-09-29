using Mcg.System;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;



namespace __InterfaceProxies
{
	public class ServiceChannelProxy_MaslataSoap : global::System.ServiceModel.Channels.ServiceChannelProxy_P, global::MyApp.ServiceReference1.MaslataSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerLoginResponse_P> global::MyApp.ServiceReference1.MaslataSoap_P.CustomerLoginAsync(global::MyApp.ServiceReference1.CustomerLoginRequest_P request)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::MyApp.ServiceReference1.MaslataSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					request
			};
			global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerLoginResponse_P> retval = ((global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerLoginResponse_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerRequistsResponse_P> global::MyApp.ServiceReference1.MaslataSoap_P.CustomerRequistsAsync(global::MyApp.ServiceReference1.CustomerRequistsRequest_P request)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::MyApp.ServiceReference1.MaslataSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					request
			};
			global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerRequistsResponse_P> retval = ((global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerRequistsResponse_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		global::System.Threading.Tasks.Task_P<bool> global::MyApp.ServiceReference1.MaslataSoap_P.PrintDocAsync(int RequestID)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::MyApp.ServiceReference1.MaslataSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					RequestID
			};
			global::System.Threading.Tasks.Task_P<bool> retval = ((global::System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	[global::System.Runtime.CompilerServices.EagerStaticClassConstruction]
	[global::System.Runtime.CompilerServices.DependencyReductionRoot]
	public static class __DispatchProxyImplementationData
	{
		static global::System.Reflection.DispatchProxyEntry[] s_entryTable = new global::System.Reflection.DispatchProxyEntry[] {
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(global::System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(global::MyApp.ServiceReference1.MaslataSoap_P).TypeHandle,
					ImplementationClassType = typeof(global::__InterfaceProxies.ServiceChannelProxy_MaslataSoap).TypeHandle,
				}
		};
		static __DispatchProxyImplementationData()
		{
			global::System.Reflection.DispatchProxyHelpers.RegisterImplementations(s_entryTable);
		}
	}
}

namespace MyApp.ServiceReference1
{
	[global::System.Runtime.InteropServices.McgRedirectedType("MyApp.ServiceReference1.MaslataSoap, MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public interface MaslataSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerLoginResponse_P> CustomerLoginAsync(global::MyApp.ServiceReference1.CustomerLoginRequest_P request);

		global::System.Threading.Tasks.Task_P<global::MyApp.ServiceReference1.CustomerRequistsResponse_P> CustomerRequistsAsync(global::MyApp.ServiceReference1.CustomerRequistsRequest_P request);

		global::System.Threading.Tasks.Task_P<bool> PrintDocAsync(int RequestID);
	}
}

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Reflection.DispatchProxy, System.Private.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
		"7f11d50a3a")]
	public class DispatchProxy_P
	{
	}
}

namespace System.ServiceModel.Channels
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.ServiceModel.Channels.ServiceChannelProxy, System.Private.ServiceModel, Version=4.0.0.0, Culture=neutral," +
		" PublicKeyToken=b03f5f7f11d50a3a")]
	public class ServiceChannelProxy_P : global::System.Reflection.DispatchProxy
	{
		protected override object Invoke(
					global::System.Reflection.MethodInfo targetMethodInfo, 
					object[] args)
		{
			return null;
		}
	}
}

namespace MyApp.ServiceReference1
{
	[global::System.Runtime.InteropServices.McgRedirectedType("MyApp.ServiceReference1.CustomerLoginResponse, MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class CustomerLoginResponse_P
	{
	}
}

namespace System.Threading.Tasks
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Threading.Tasks.Task`1, System.Private.Threading, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
		"7f11d50a3a")]
	public class Task_P<TResult>
	{
	}
}

namespace MyApp.ServiceReference1
{
	[global::System.Runtime.InteropServices.McgRedirectedType("MyApp.ServiceReference1.CustomerLoginRequest, MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class CustomerLoginRequest_P
	{
	}
}

namespace MyApp.ServiceReference1
{
	[global::System.Runtime.InteropServices.McgRedirectedType("MyApp.ServiceReference1.CustomerRequistsResponse, MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class CustomerRequistsResponse_P
	{
	}
}

namespace MyApp.ServiceReference1
{
	[global::System.Runtime.InteropServices.McgRedirectedType("MyApp.ServiceReference1.CustomerRequistsRequest, MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class CustomerRequistsRequest_P
	{
	}
}
