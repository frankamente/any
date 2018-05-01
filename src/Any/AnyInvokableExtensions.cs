﻿using System;
using System.Threading.Tasks;

namespace AnyCore
{
  public static class AnyInvokableExtensions
  {
    public static Task NotStartedTask(this MyGenerator gen)
    {
      return gen.AllGenerator.NotStartedTask();
    }

    public static Task<T> NotStartedTask<T>(this MyGenerator gen)
    {
      return gen.AllGenerator.NotStartedTask<T>();
    }

    public static Task<T> StartedTask<T>(this MyGenerator gen)
    {
      return gen.AllGenerator.StartedTask<T>();
    }

    public static Func<T> Func<T>(this MyGenerator gen)
    {
      return gen.AllGenerator.Func<T>();
    }

    public static Func<T1, T2> Func<T1, T2>(this MyGenerator gen)
    {
      return gen.AllGenerator.Func<T1, T2>();
    }

    public static Func<T1, T2, T3> Func<T1, T2, T3>(this MyGenerator gen)
    {
      return gen.AllGenerator.Func<T1, T2, T3>();
    }

    public static Func<T1, T2, T3, T4> Func<T1, T2, T3, T4>(this MyGenerator gen)
    {
      return gen.AllGenerator.Func<T1, T2, T3, T4>();
    }

    public static Func<T1, T2, T3, T4, T5> Func<T1, T2, T3, T4, T5>(this MyGenerator gen)
    {
      return gen.AllGenerator.Func<T1, T2, T3, T4, T5>();
    }

    public static Func<T1, T2, T3, T4, T5, T6> Func<T1, T2, T3, T4, T5, T6>(this MyGenerator gen)
    {
      return gen.AllGenerator.Func<T1, T2, T3, T4, T5, T6>();
    }

    public static Action Action(this MyGenerator gen)
    {
      return gen.AllGenerator.Action();
    }

    public static Action<T> Action<T>(this MyGenerator gen)
    {
      return gen.AllGenerator.Action<T>();
    }

    public static Action<T1, T2> Action<T1, T2>(this MyGenerator gen)
    {
      return gen.AllGenerator.Action<T1, T2>();
    }

    public static Action<T1, T2, T3> Action<T1, T2, T3>(this MyGenerator gen)
    {
      return gen.AllGenerator.Action<T1, T2, T3>();
    }

    public static Action<T1, T2, T3, T4> Action<T1, T2, T3, T4>(this MyGenerator gen)
    {
      return gen.AllGenerator.Action<T1, T2, T3, T4>();
    }

    public static Action<T1, T2, T3, T4, T5> Action<T1, T2, T3, T4, T5>(this MyGenerator gen)
    {
      return gen.AllGenerator.Action<T1, T2, T3, T4, T5>();
    }

    public static Action<T1, T2, T3, T4, T5, T6> Action<T1, T2, T3, T4, T5, T6>(this MyGenerator gen)
    {
      return gen.AllGenerator.Action<T1, T2, T3, T4, T5, T6>();
    }
  }
}