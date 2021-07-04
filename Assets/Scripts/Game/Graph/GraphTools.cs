using System;
using UnityEngine;
using System.Collections;

///
///Class to support initial build and consumption by procgen system, also maintains any inputs over time
///The "data side" of the procedural generator
public class GraphSetting
{

}

public class LevelGraph
{
    public RawLevelGraph _raw = new RawLevelGraph();
    private List<LevelGraphNode> _graphNodes;
    public List<LevelGraphNode> graphNodes
    {
        get { return _graphNodes; }
        set { _graphNodes = value; }
    }

    private List<LevelGraphEdge> _graphEdges;
    public List<LevelGraphEdge> graphEdges
    {
        get { return _graphEdges; }
        set { _graphEdges = value; }
    }

    private List<LevelGraphChunk> _graphChunks;
    public List<LevelGraphChunk> graphChunks
    {
        get { return _graphChunks; }
        set { _graphChunks = value; }
    }
    public bool _loaded = false;

    public LevelGraph(string _json){

    }
    
    //TODO:
        //Intake from JSON, converts to RawLevelGraph and consumes to Graphs, Nodes, Edges
        //Adjacency chunking method for performance, outputs LevelGraphChunks
        //Support for a hook to update the JSON in real time
        //Publics: chunked collection, id-based dictionary (maybe these are one thing)
}

///
///All the JSON stuff here
public class RawLevelGraph{

}

///
///See JSON sample. id, coordinates, adjacency list, seed.
public class LevelGraphNode
{

}

///
///Maybe vestigial or not usable. What are the parameters of a graph edge? Just weight?
public class LevelGraphEdge
{

}

///
///Adjacency-filtered chunk from a level graph, speculative obj for perf enhancement
public class LevelGraphChunk
{

}