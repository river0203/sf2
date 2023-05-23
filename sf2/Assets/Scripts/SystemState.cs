using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SystemState
{
    public static enum Key
    {
        none,
        db, // 사진의 1~9까지
        d,
        fd, 
        b,
        n, 
        f,
        ub,
        u,
        uf, 
        A = 5, //약손
        B = 6, //약발
        C = 8, //강손
        D = 10, //강발
        
    }
    public static enum status
    {
        Move,
        Attack,
        Jump,
        //아도겐은 펀치의 강,중,약에 따라 날아가는 속도가 달라짐
        strongadogen = 15, //강파동권
        middleadogen = 11, //중파동권
        strongpiggybacking, //강 업어치기
        middlepiggybacking, //중 업어치기
        strongbackandflipping, //강 배대뒤치기
        middlebackandflipping, //중 배대뒤치기
        breakingthecollarbone = 14, //쇄골깨기
        pitofthestomach = 16, //명치부수기
        oryugen = 24, //승룡권
        //용권선풍각은 킥의 강,중 에 따라 거리가 달라짐
        strongaddaddaddugen = 35, //강용권선풍각
        middleaddaddaddugen = 28, //중용권선풍각
        airaddaddaddugen = 24, //공중 용권선풍각
    }

    public void Commandlist()
    {
        Key [] strongadogen = {Key.d,Key.fd,Key.f,Key.C};
        Key [] middleadogen = {Key.d,Key.fd,Key.f,Key.A};
        Key [] strongaddaddaddugen = {Key.d,Key.db,Key.b,Key.D};        
        Key [] middleaddaddaddugen = {Key.d,Key.db,Key.b,Key.B};
        Key [] strongpiggybacking = {Key.b,Key.C};
        Key [] strongpiggybacking = {Key.f,Key.C};
        Key [] middlepiggybacking = {Key.b,Key.A};
        Key [] middlepiggybacking = {Key.f,Key.A};
        Key [] strongbackandflipping = {Key.b,Key.D};
        Key [] strongbackandflipping = {Key.f,Key.D};
        Key [] middlebackandflipping = {Key.b,Key.B};
        Key [] middlebackandflipping = {Key.f,Key.B};
        Key [] breakingthecollarbone = {Key.f,Key.A};
        Key [] pitofthestomach = {Key.f,Key.C};
        Key [] oryugen = {Key.f,Key.d,Key.fd,Key.C};        
        Key [] oryugen = {Key.f,Key.d,Key.fd,Key.A};
        Key [] sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.C};
        Key [] sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.A};
    }
    
    public SystemState _Commandlist {get;}
    public SystemState _getKey {get;}
}
