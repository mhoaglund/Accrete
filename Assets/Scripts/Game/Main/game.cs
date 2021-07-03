#define DEBUG_LOGGING
using UnityEngine;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.HDPipeline;
using System;
using System.Globalization;
using UnityEngine.Rendering.PostProcessing;
using SQP;
#if UNITY_EDITOR
using UnityEditor;
#endif

public struct GameTime
{
    /// <summary>Number of ticks per second.</summary>
    public int tickRate
    {
        get { return m_tickRate; }
        set
        {
            m_tickRate = value;
            tickInterval = 1.0f / m_tickRate;
        }
    }

    /// <summary>Length of each world tick at current tickrate, e.g. 0.0166s if ticking at 60fps.</summary>
    public float tickInterval { get; private set; }     // Time between ticks
    public int tick;                    // Current tick   
    public float tickDuration;          // Duration of current tick

    public GameTime(int tickRate)    
    {
        this.m_tickRate = tickRate;
        this.tickInterval = 1.0f / m_tickRate;
        this.tick = 1;
        this.tickDuration = 0;
    }

    public float TickDurationAsFraction
    {
        get { return tickDuration / tickInterval; }
    }

    public void SetTime(int tick, float tickDuration)
    {
        this.tick = tick;
        this.tickDuration = tickDuration;
    }

    public float DurationSinceTick(int tick)
    {
        return (this.tick - tick) * tickInterval + tickDuration;
    }

    public void AddDuration(float duration)
    {
        tickDuration += duration;
        int deltaTicks = Mathf.FloorToInt(tickDuration * (float)tickRate);
        tick += deltaTicks;
        tickDuration = tickDuration % tickInterval;
    }

    public static float GetDuration(GameTime start, GameTime end)
    {
        if(start.tickRate != end.tickRate)     
        {
            GameDebug.LogError("Trying to compare time with different tick rates (" + start.tickRate + " and " + end.tickRate + ")");
            return 0;
        }

        float result = (end.tick - start.tick) * start.tickInterval + end.tickDuration - start.tickDuration;
        return result;
    }

    int m_tickRate;
}

[DefaultExecutionOrder(-1000)]
public class Game : MonoBehaviour
{
    //can't really remember how to do this.
    void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Generate();
            }
        }
}
