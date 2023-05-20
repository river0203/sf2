using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SystemState
{
    enum Key
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
        A, //약손
        B, //약발
        C, //강손
        D, //강발
        
    }
    enum status
    {
        Move,
        Attack,
        //아도겐은 펀치의 강,중,약에 따라 날아가는 속도가 달라짐
        strongadogen, //강파동권
        middleadogen, //중파동권
        weakadogen, //약파동권

        strongpiggybacking, //강 업어치기
        middlepiggybacking, //중 업어치기
        strongbackandflipping, //강 배대뒤치기
        middlebackandflipping, //중 배대뒤치기
        breakingthecollarbone, //쇄골깨기
        pitofthestomach, //명치부수기
        oryugen, //승룡권
        //용권선풍각은 킥의 강,중 에 따라 거리가 달라짐
        strongaddaddaddugen, //강용권선풍각
        middleaddaddaddugen, //중용권선풍각
        weakaddaddaddugen, //약용권선풍각
        airaddaddaddugen, //공중 용권선풍각
    }

    Key [] strongadogen = {Key.down,Key.downright,Key.right,Key.strongpunch};
    Key [] middleadogen = {Key.down,Key.downright,Key.right,Key.middlepunch};
    Key [] strongaddaddaddugen = {Key.down,Key.downleft,Key.left,Key.strongkick};
    Key [] middleaddaddaddugen = {Key.down,Key.downleft,Key.left,Key.middlekick};
    Key [] strongpiggybacking = {Key.left,Key.strongpunch};
    Key [] strongpiggybacking = {Key.right,Key.strongpunch};
    Key [] middlepiggybacking = {Key.left,Key.middlepunch};
    Key [] middlepiggybacking = {Key.right,Key.middlepunch};
    Key [] strongbackandflipping = {Key.left,Key.strongkick};
    Key [] strongbackandflipping = {Key.right,Key.strongkick};
    Key [] middlebackandflipping = {Key.left,Key.middlekick};
    Key [] middlebackandflipping = {Key.right,Key.middlekick};
    Key [] breakingthecollarbone = {Key.right,Key.middlepunch};
    Key [] pitofthestomach = {Key.right,Key.strongpunch};
    Key [] oryugen = {Key.right,Key.down,Key.downright,Key.strongpunch};
    Key [] oryugen = {Key.right,Key.down,Key.downright,Key.middlepunch};
    Key [] sinkuadogen = {Key.down,Key.downright,Key.right,Key.down,Key.downright,Key.right,Key.strongpunch};
    Key [] sinkuadogen = {Key.down,Key.downright,Key.right,Key.down,Key.downright,Key.right,Key.middlepunch};


}