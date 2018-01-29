﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProcSkinAnim
{

    public struct GPUBone {
        public Vector3 position;
        // public Quaternion rotation;
        public Matrix4x4 rotation;
        public Vector3 scale;

        public Matrix4x4 comb, local, offset;

        public GPUBone(Vector3 tr, Quaternion rot, Vector3 s)
        {
            comb = Matrix4x4.identity;
            local = Matrix4x4.TRS(tr, rot, s);
            offset = local.inverse;

            position = Vector3.zero;
            // rotation = Quaternion.identity;
            rotation = Matrix4x4.identity;
            scale = Vector3.one;
        }
    };

    public struct GPUBoneWeight {
        public float weight0, weight1, weight2, weight3;
        public uint boneIndex0, boneIndex1, boneIndex2, boneIndex3;
    };

}


