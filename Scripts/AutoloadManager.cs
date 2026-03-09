using Godot;
using System;

public static class AutoloadManager
{
    public static T GetAutoload<T>() where T : Node
    {
        SceneTree tree = Engine.GetMainLoop() as SceneTree;
        return tree.Root.GetNode<T>("/root/"+typeof(T).Name);
    }
}