using NLua;
using System;
using System.Collections.Generic;
using UnityEngine;


public class LuaStateIntegration 
{
    public NLua.Lua Lua { get; private set; }
    private CharacterBehaviour characterBehaviour;
    //private MoveToState moveToState;


    public LuaStateIntegration(CharacterBehaviour characterBehaviour)
    {
        this.characterBehaviour = characterBehaviour;

        Lua = new NLua.Lua();


    }

    public void LoadLuaFile(int id)
    {

        string filePath = string.Format("ai{0}.lua", id);

        Lua.DoFile(filePath);
    }

    public void SendVariablesToLuaProps()
    {
        Lua["CharacterBehaviour"] = characterBehaviour;

    }

    public void TryCallLuaMethod(string methodName, params object[] args)
    {
        try {
            ((LuaFunction)Lua[methodName]).Call(args);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }










}
