using System;
using UnityEngine;

namespace EventFramework.Arguments.Abstractions {
	public interface IDataRequestArguments {
		Action CallBack { get; }
		
		GameObject GameObject { get; }
		
	    IEventArguments EventArguments { get; }
	}
}