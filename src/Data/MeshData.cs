﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TunicRandomizer {
    public class MeshData {

        public struct MeshInfo {
            public Vector3[] normals;
            public int[] triangles;
            public Vector2[] uvs;
            public Vector3[] vertices;

            public MeshInfo(Vector3[] Normals, int[] Triangles, Vector2[] Uvs, Vector3[] Vertices) {
                normals = Normals;
                triangles = Triangles;
                uvs = Uvs;
                vertices = Vertices;
            }
        }

        public static MeshInfo DathStone = new MeshInfo(
            new List<Vector3>() { new Vector3(-0.4706348f, 0.3376524f, -0.8151648f), new Vector3(-0.4706348f, 0.3376524f, -0.8151648f), new Vector3(-0.4706348f, 0.3376524f, -0.8151648f), new Vector3(-0.4706348f, 0.3376524f, -0.8151648f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-0.4706358f, -0.3376518f, 0.8151644f), new Vector3(-0.4706358f, -0.3376518f, 0.8151644f), new Vector3(-0.4706358f, -0.3376518f, 0.8151644f), new Vector3(-0.4706358f, -0.3376518f, 0.8151644f), new Vector3(0.4706359f, -0.3376522f, 0.8151644f), new Vector3(0.4706359f, -0.3376522f, 0.8151644f), new Vector3(0.4706359f, -0.3376522f, 0.8151644f), new Vector3(0.4706359f, -0.3376522f, 0.8151644f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(0.4706346f, 0.3376522f, -0.8151651f), new Vector3(0.4706346f, 0.3376522f, -0.8151651f), new Vector3(0.4706346f, 0.3376522f, -0.8151651f), new Vector3(0.4706346f, 0.3376522f, -0.8151651f), new Vector3(-0.4706357f, 0.8151644f, -0.3376524f), new Vector3(-0.4706357f, 0.8151644f, -0.3376524f), new Vector3(-0.4706357f, 0.8151644f, -0.3376524f), new Vector3(-0.4706357f, 0.8151644f, -0.3376524f), new Vector3(-0.4706362f, -0.8151644f, 0.3376516f), new Vector3(-0.4706362f, -0.8151644f, 0.3376516f), new Vector3(-0.4706362f, -0.8151644f, 0.3376516f), new Vector3(-0.4706362f, -0.8151644f, 0.3376516f), new Vector3(0.4706359f, -0.8151642f, 0.3376525f), new Vector3(0.4706359f, -0.8151642f, 0.3376525f), new Vector3(0.4706359f, -0.8151642f, 0.3376525f), new Vector3(0.4706359f, -0.8151642f, 0.3376525f), new Vector3(0.4706357f, 0.8151644f, -0.3376523f), new Vector3(0.4706357f, 0.8151644f, -0.3376523f), new Vector3(0.4706357f, 0.8151644f, -0.3376523f), new Vector3(0.4706357f, 0.8151644f, -0.3376523f), new Vector3(-0.4706357f, 0.8151644f, 0.3376519f), new Vector3(-0.4706357f, 0.8151644f, 0.3376519f), new Vector3(-0.4706357f, 0.8151644f, 0.3376519f), new Vector3(-0.4706357f, 0.8151644f, 0.3376519f), new Vector3(-0.4706359f, -0.8151646f, -0.3376514f), new Vector3(-0.4706359f, -0.8151646f, -0.3376514f), new Vector3(-0.4706359f, -0.8151646f, -0.3376514f), new Vector3(-0.4706359f, -0.8151646f, -0.3376514f), new Vector3(0.4706354f, -0.8151644f, -0.3376523f), new Vector3(0.4706354f, -0.8151644f, -0.3376523f), new Vector3(0.4706354f, -0.8151644f, -0.3376523f), new Vector3(0.4706354f, -0.8151644f, -0.3376523f), new Vector3(0.4706356f, 0.8151644f, 0.3376522f), new Vector3(0.4706356f, 0.8151644f, 0.3376522f), new Vector3(0.4706356f, 0.8151644f, 0.3376522f), new Vector3(0.4706356f, 0.8151644f, 0.3376522f), new Vector3(-0.4706346f, 0.3376518f, 0.8151652f), new Vector3(-0.4706346f, 0.3376518f, 0.8151652f), new Vector3(-0.4706346f, 0.3376518f, 0.8151652f), new Vector3(-0.4706346f, 0.3376518f, 0.8151652f), new Vector3(-0.4706354f, -0.3376517f, -0.8151649f), new Vector3(-0.4706354f, -0.3376517f, -0.8151649f), new Vector3(-0.4706354f, -0.3376517f, -0.8151649f), new Vector3(-0.4706354f, -0.3376517f, -0.8151649f), new Vector3(0.470635f, -0.3376517f, -0.815165f), new Vector3(0.470635f, -0.3376517f, -0.815165f), new Vector3(0.470635f, -0.3376517f, -0.815165f), new Vector3(0.470635f, -0.3376517f, -0.815165f), new Vector3(0.4706348f, 0.3376519f, 0.815165f), new Vector3(0.4706348f, 0.3376519f, 0.815165f), new Vector3(0.4706348f, 0.3376519f, 0.815165f), new Vector3(0.4706348f, 0.3376519f, 0.815165f), new Vector3(-0.4706348f, -0.3376525f, 0.8151648f), new Vector3(-0.4706348f, -0.3376525f, 0.8151648f), new Vector3(-0.4706348f, -0.3376525f, 0.8151648f), new Vector3(-0.4706348f, -0.3376525f, 0.8151648f), new Vector3(-0.4706353f, 0.3376525f, -0.8151646f), new Vector3(-0.4706353f, 0.3376525f, -0.8151646f), new Vector3(-0.4706353f, 0.3376525f, -0.8151646f), new Vector3(-0.4706353f, 0.3376525f, -0.8151646f), new Vector3(0.470635f, 0.3376526f, -0.8151647f), new Vector3(0.470635f, 0.3376526f, -0.8151647f), new Vector3(0.470635f, 0.3376526f, -0.8151647f), new Vector3(0.470635f, 0.3376526f, -0.8151647f), new Vector3(0.4706341f, -0.3376525f, 0.8151652f), new Vector3(0.4706341f, -0.3376525f, 0.8151652f), new Vector3(0.4706341f, -0.3376525f, 0.8151652f), new Vector3(0.4706341f, -0.3376525f, 0.8151652f), new Vector3(-0.4706357f, -0.8151641f, 0.337653f), new Vector3(-0.4706357f, -0.8151641f, 0.337653f), new Vector3(-0.4706357f, -0.8151641f, 0.337653f), new Vector3(-0.4706357f, -0.8151641f, 0.337653f), new Vector3(-0.4706353f, 0.8151644f, -0.337653f), new Vector3(-0.4706353f, 0.8151644f, -0.337653f), new Vector3(-0.4706353f, 0.8151644f, -0.337653f), new Vector3(-0.4706353f, 0.8151644f, -0.337653f), new Vector3(0.4706354f, 0.8151647f, -0.337652f), new Vector3(0.4706354f, 0.8151647f, -0.337652f), new Vector3(0.4706354f, 0.8151647f, -0.337652f), new Vector3(0.4706354f, 0.8151647f, -0.337652f), new Vector3(0.470635f, -0.8151646f, 0.3376527f), new Vector3(0.470635f, -0.8151646f, 0.3376527f), new Vector3(0.470635f, -0.8151646f, 0.3376527f), new Vector3(0.470635f, -0.8151646f, 0.3376527f), new Vector3(-0.4706353f, -0.8151646f, -0.3376522f), new Vector3(-0.4706353f, -0.8151646f, -0.3376522f), new Vector3(-0.4706353f, -0.8151646f, -0.3376522f), new Vector3(-0.4706353f, -0.8151646f, -0.3376522f), new Vector3(-0.4706359f, 0.8151641f, 0.3376528f), new Vector3(-0.4706359f, 0.8151641f, 0.3376528f), new Vector3(-0.4706359f, 0.8151641f, 0.3376528f), new Vector3(-0.4706359f, 0.8151641f, 0.3376528f), new Vector3(0.4706362f, 0.8151641f, 0.3376524f), new Vector3(0.4706362f, 0.8151641f, 0.3376524f), new Vector3(0.4706362f, 0.8151641f, 0.3376524f), new Vector3(0.4706362f, 0.8151641f, 0.3376524f), new Vector3(0.4706352f, -0.8151646f, -0.3376526f), new Vector3(0.4706352f, -0.8151646f, -0.3376526f), new Vector3(0.4706352f, -0.8151646f, -0.3376526f), new Vector3(0.4706352f, -0.8151646f, -0.3376526f), new Vector3(-0.4706343f, -0.3376526f, -0.8151651f), new Vector3(-0.4706343f, -0.3376526f, -0.8151651f), new Vector3(-0.4706343f, -0.3376526f, -0.8151651f), new Vector3(-0.4706343f, -0.3376526f, -0.8151651f), new Vector3(-0.4706361f, 0.337653f, 0.8151639f), new Vector3(-0.4706361f, 0.337653f, 0.8151639f), new Vector3(-0.4706361f, 0.337653f, 0.8151639f), new Vector3(-0.4706361f, 0.337653f, 0.8151639f), new Vector3(0.470636f, 0.3376528f, 0.8151641f), new Vector3(0.470636f, 0.3376528f, 0.8151641f), new Vector3(0.470636f, 0.3376528f, 0.8151641f), new Vector3(0.470636f, 0.3376528f, 0.8151641f), new Vector3(0.4706344f, -0.3376528f, -0.8151649f), new Vector3(0.4706344f, -0.3376528f, -0.8151649f), new Vector3(0.4706344f, -0.3376528f, -0.8151649f), new Vector3(0.4706344f, -0.3376528f, -0.8151649f), new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f), new Vector3(0f, 0f, -1f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-0.5f, -0.8660254f, 0f), new Vector3(-0.5f, -0.8660254f, 0f), new Vector3(-0.5f, -0.8660254f, 0f), new Vector3(-0.5f, -0.8660254f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(0.5000001f, 0.8660253f, 0f), new Vector3(0.5000001f, 0.8660253f, 0f), new Vector3(0.5000001f, 0.8660253f, 0f), new Vector3(0.5000001f, 0.8660253f, 0f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-0.5f, 0.8660254f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-1f, 0f, 0f), new Vector3(-0.4999999f, -0.8660254f, 0f), new Vector3(-0.4999999f, -0.8660254f, 0f), new Vector3(-0.4999999f, -0.8660254f, 0f), new Vector3(-0.4999999f, -0.8660254f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(0.5000001f, -0.8660253f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(1f, 0f, 0f), new Vector3(0.5f, 0.8660254f, 0f), new Vector3(0.5f, 0.8660254f, 0f), new Vector3(0.5f, 0.8660254f, 0f), new Vector3(0.5f, 0.8660254f, 0f), new Vector3(-0.4746854f, 0.2740395f, 0.8364066f), new Vector3(-0.4020888f, 0.2321461f, 0.8856821f), new Vector3(0f, 0.4642922f, 0.8856821f), new Vector3(1.758447E-05f, 0.5481094f, 0.8364067f), new Vector3(-0.4746679f, -0.2740699f, 0.8364066f), new Vector3(-0.4020889f, -0.2321461f, 0.8856821f), new Vector3(1.759827E-05f, -0.5481094f, 0.8364067f), new Vector3(0f, -0.4642922f, 0.8856821f), new Vector3(0.4746855f, -0.2740393f, 0.8364067f), new Vector3(0.4020888f, -0.232146f, 0.8856821f), new Vector3(0.4746679f, 0.2740699f, 0.8364067f), new Vector3(0.4020889f, 0.232146f, 0.8856821f), new Vector3(-1.394749E-05f, 0.434186f, 0.9008232f), new Vector3(0f, 0.2751192f, 0.9614102f), new Vector3(0.2382601f, 0.1375596f, 0.9614101f), new Vector3(0.3760925f, 0.2169608f, 0.9008232f), new Vector3(0.2382602f, -0.1375595f, 0.9614101f), new Vector3(0.3759399f, -0.2172252f, 0.9008232f), new Vector3(0f, -0.2751192f, 0.9614101f), new Vector3(-1.384333E-05f, -0.4341861f, 0.9008232f), new Vector3(-0.2382602f, -0.1375596f, 0.9614101f), new Vector3(-0.3760231f, -0.217081f, 0.9008232f), new Vector3(-0.2382601f, 0.1375596f, 0.9614101f), new Vector3(-0.3760092f, 0.217105f, 0.9008232f), new Vector3(1.756102E-05f, 0.2751192f, 0.9614102f), new Vector3(-0.2382514f, 0.1375748f, 0.9614101f), new Vector3(-0.2382689f, -0.1375444f, 0.9614101f), new Vector3(-1.753122E-05f, -0.2751192f, 0.9614101f), new Vector3(0.238269f, 0.1375444f, 0.9614101f), new Vector3(0.2382514f, -0.1375748f, 0.9614101f) }.ToArray(),
            new List<int>() { 0, 1, 2, 0, 2, 3, 4, 5, 6, 4, 6, 7, 7, 6, 8, 7, 8, 9, 9, 8, 10, 9, 10, 11, 11, 10, 12, 11, 12, 13, 13, 12, 14, 13, 14, 15, 15, 14, 16, 15, 16, 17, 17, 16, 18, 17, 18, 19, 19, 18, 5, 19, 5, 4, 20, 21, 22, 20, 22, 23, 24, 25, 26, 24, 26, 27, 28, 29, 30, 28, 30, 31, 31, 30, 32, 31, 32, 33, 33, 32, 34, 33, 34, 35, 35, 34, 36, 35, 36, 37, 37, 36, 38, 37, 38, 39, 39, 38, 40, 39, 40, 41, 41, 40, 42, 41, 42, 43, 43, 42, 29, 43, 29, 28, 44, 45, 46, 44, 46, 47, 48, 49, 50, 48, 50, 51, 52, 53, 54, 52, 54, 55, 56, 57, 58, 56, 58, 59, 60, 61, 62, 60, 62, 63, 64, 65, 66, 64, 66, 67, 68, 69, 70, 68, 70, 71, 72, 73, 74, 72, 74, 75, 76, 77, 78, 76, 78, 79, 80, 81, 82, 80, 82, 83, 84, 85, 86, 84, 86, 87, 88, 89, 90, 88, 90, 91, 92, 93, 94, 92, 94, 95, 96, 97, 98, 96, 98, 99, 100, 101, 102, 100, 102, 103, 104, 105, 106, 104, 106, 107, 108, 109, 110, 108, 110, 111, 112, 113, 114, 112, 114, 115, 116, 117, 118, 116, 118, 119, 120, 121, 122, 120, 122, 123, 124, 125, 126, 124, 126, 127, 128, 129, 130, 128, 130, 131, 132, 133, 134, 132, 134, 135, 136, 137, 138, 136, 138, 139, 140, 141, 142, 140, 142, 143, 144, 145, 146, 144, 146, 147, 148, 149, 150, 148, 150, 151, 152, 153, 154, 152, 154, 155, 156, 157, 158, 156, 158, 159, 160, 161, 162, 160, 163, 161, 160, 164, 163, 160, 165, 164, 160, 166, 165, 160, 162, 166, 167, 168, 169, 167, 169, 170, 171, 172, 173, 171, 173, 174, 175, 176, 177, 175, 177, 178, 179, 180, 181, 179, 181, 182, 183, 184, 185, 183, 185, 186, 187, 188, 189, 187, 189, 190, 191, 192, 193, 191, 193, 194, 195, 196, 197, 195, 197, 198, 199, 200, 201, 199, 201, 202, 203, 204, 205, 203, 205, 206, 207, 208, 209, 207, 209, 210, 211, 212, 213, 211, 213, 214, 215, 216, 217, 215, 217, 218, 219, 216, 215, 219, 220, 216, 221, 220, 219, 221, 222, 220, 223, 222, 221, 223, 224, 222, 225, 224, 223, 225, 226, 224, 218, 217, 226, 218, 226, 225, 227, 228, 229, 227, 229, 230, 230, 229, 231, 230, 231, 232, 232, 231, 233, 232, 233, 234, 234, 233, 235, 234, 235, 236, 236, 235, 237, 236, 237, 238, 238, 237, 228, 238, 228, 227, 239, 240, 241, 241, 242, 239, 242, 243, 239, 242, 244, 243 }.ToArray(),
            new List<Vector2>() { new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05322358f, 0.08420542f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05322358f, 0.08205703f), new Vector2(0.05322358f, 0.08420542f), new Vector2(0.05322358f, 0.08428445f), new Vector2(0.05322358f, 0.08732274f), new Vector2(0.05322358f, 0.08205703f), new Vector2(0.05322358f, 0.08420542f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05322358f, 0.07130221f), new Vector2(0.05322358f, 0.06915382f), new Vector2(0.05322358f, 0.06907478f), new Vector2(0.05322358f, 0.06603655f), new Vector2(0.05322358f, 0.07130221f), new Vector2(0.05322358f, 0.06915382f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.05322358f, 0.08205703f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.04796109f, 0.08205703f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.04796109f, 0.08420542f), new Vector2(0.04796109f, 0.08205703f), new Vector2(0.04796109f, 0.08732274f), new Vector2(0.04796109f, 0.08428445f), new Vector2(0.04796109f, 0.08420542f), new Vector2(0.04796109f, 0.08205703f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.04796109f, 0.06915382f), new Vector2(0.04796109f, 0.07130221f), new Vector2(0.04796109f, 0.06603655f), new Vector2(0.04796109f, 0.06907478f), new Vector2(0.04796109f, 0.06915382f), new Vector2(0.04796109f, 0.07130221f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.04796109f, 0.08420542f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.05322358f, 0.08420542f), new Vector2(0.05322358f, 0.08732274f), new Vector2(0.05059233f, 0.08884189f), new Vector2(0.05322358f, 0.08205703f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.05059233f, 0.08276531f), new Vector2(0.05322358f, 0.08428445f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.04796109f, 0.08205703f), new Vector2(0.04796109f, 0.08428445f), new Vector2(0.05059233f, 0.08276531f), new Vector2(0.04796109f, 0.08420542f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.05059233f, 0.08884189f), new Vector2(0.04796109f, 0.08732274f), new Vector2(0.05059233f, 0.08884189f), new Vector2(0.05322358f, 0.08732274f), new Vector2(0.05322358f, 0.08420542f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.05322358f, 0.08428445f), new Vector2(0.05059233f, 0.08276531f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.05322358f, 0.08205703f), new Vector2(0.05059233f, 0.08276531f), new Vector2(0.04796109f, 0.08428445f), new Vector2(0.04796109f, 0.08205703f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.04796109f, 0.08732274f), new Vector2(0.05059233f, 0.08884189f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.04796109f, 0.08420542f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.05322358f, 0.08420542f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05322358f, 0.08205703f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05059233f, 0.08098283f), new Vector2(0.04796109f, 0.08205703f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.04796109f, 0.08420542f), new Vector2(0.05059233f, 0.08527961f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05322358f, 0.06915382f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.05322358f, 0.07130221f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.04796109f, 0.07130221f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.04796109f, 0.06915382f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.05322358f, 0.06915382f), new Vector2(0.05322358f, 0.06603655f), new Vector2(0.05059233f, 0.06451741f), new Vector2(0.05322358f, 0.07130221f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.05059233f, 0.07059392f), new Vector2(0.05322358f, 0.06907478f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.04796109f, 0.07130221f), new Vector2(0.04796109f, 0.06907478f), new Vector2(0.05059233f, 0.07059392f), new Vector2(0.04796109f, 0.06915382f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.05059233f, 0.06451741f), new Vector2(0.04796109f, 0.06603655f), new Vector2(0.05059233f, 0.06451741f), new Vector2(0.05322358f, 0.06603655f), new Vector2(0.05322358f, 0.06915382f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.05322358f, 0.06907478f), new Vector2(0.05059233f, 0.07059392f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.05322358f, 0.07130221f), new Vector2(0.05059233f, 0.07059392f), new Vector2(0.04796109f, 0.06907478f), new Vector2(0.04796109f, 0.07130221f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.04796109f, 0.06603655f), new Vector2(0.05059233f, 0.06451741f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.04796109f, 0.06915382f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.05322358f, 0.06915382f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05322358f, 0.07130221f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.05322358f, 0.07667962f), new Vector2(0.05059233f, 0.0723764f), new Vector2(0.04796109f, 0.07130221f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.04796109f, 0.06915382f), new Vector2(0.05059233f, 0.06807962f), new Vector2(0.05059233f, 0.07667962f), new Vector2(0.04796109f, 0.07667962f), new Vector2(0.05059233f, 0.04626694f), new Vector2(0.07401308f, 0.05978891f), new Vector2(0.05059233f, 0.07331088f), new Vector2(0.07401308f, 0.03274494f), new Vector2(0.05059233f, 0.01922297f), new Vector2(0.02717158f, 0.03274497f), new Vector2(0.02717158f, 0.05978891f), new Vector2(0.05059233f, 0.07331088f), new Vector2(0.07401308f, 0.05978891f), new Vector2(0.07401308f, 0.05978891f), new Vector2(0.05059233f, 0.07331088f), new Vector2(0.07401308f, 0.05978891f), new Vector2(0.07401308f, 0.03274494f), new Vector2(0.07401308f, 0.03274494f), new Vector2(0.07401308f, 0.05978891f), new Vector2(0.07401308f, 0.03274494f), new Vector2(0.05059233f, 0.01922297f), new Vector2(0.05059233f, 0.01922297f), new Vector2(0.07401308f, 0.03274494f), new Vector2(0.05059233f, 0.01922297f), new Vector2(0.02717158f, 0.03274497f), new Vector2(0.02717158f, 0.03274497f), new Vector2(0.05059233f, 0.01922297f), new Vector2(0.02717158f, 0.03274497f), new Vector2(0.02717158f, 0.05978891f), new Vector2(0.02717158f, 0.05978891f), new Vector2(0.02717158f, 0.03274497f), new Vector2(0.02717158f, 0.05978891f), new Vector2(0.05059233f, 0.07331088f), new Vector2(0.05059233f, 0.07331088f), new Vector2(0.02717158f, 0.05978891f), new Vector2(0.06932893f, 0.05708453f), new Vector2(0.06932893f, 0.05708453f), new Vector2(0.05059233f, 0.06790212f), new Vector2(0.05059233f, 0.06790212f), new Vector2(0.06932893f, 0.03544936f), new Vector2(0.06932893f, 0.03544936f), new Vector2(0.06932893f, 0.05708453f), new Vector2(0.06932893f, 0.05708453f), new Vector2(0.05059233f, 0.02463177f), new Vector2(0.05059233f, 0.02463177f), new Vector2(0.06932893f, 0.03544936f), new Vector2(0.06932893f, 0.03544936f), new Vector2(0.03185573f, 0.03544936f), new Vector2(0.03185573f, 0.03544936f), new Vector2(0.05059233f, 0.02463177f), new Vector2(0.05059233f, 0.02463177f), new Vector2(0.03185573f, 0.05708453f), new Vector2(0.03185573f, 0.05708453f), new Vector2(0.03185573f, 0.03544936f), new Vector2(0.03185573f, 0.03544936f), new Vector2(0.05059233f, 0.06790212f), new Vector2(0.05059233f, 0.06790212f), new Vector2(0.03185573f, 0.05708453f), new Vector2(0.03185573f, 0.05708453f), new Vector2(0.07401308f, 0.05978891f), new Vector2(0.06932893f, 0.05708453f), new Vector2(0.05059233f, 0.06790212f), new Vector2(0.05059233f, 0.07331088f), new Vector2(0.07401308f, 0.03274494f), new Vector2(0.06932893f, 0.03544936f), new Vector2(0.05059233f, 0.01922297f), new Vector2(0.05059233f, 0.02463177f), new Vector2(0.02717158f, 0.03274497f), new Vector2(0.03185573f, 0.03544936f), new Vector2(0.02717158f, 0.05978891f), new Vector2(0.03185573f, 0.05708453f), new Vector2(0.05059233f, 0.06790212f), new Vector2(0.05059233f, 0.05911216f), new Vector2(0.03946802f, 0.05268952f), new Vector2(0.03185573f, 0.05708453f), new Vector2(0.03946802f, 0.03984433f), new Vector2(0.03185573f, 0.03544936f), new Vector2(0.05059233f, 0.03342173f), new Vector2(0.05059233f, 0.02463177f), new Vector2(0.06171665f, 0.03984433f), new Vector2(0.06932893f, 0.03544936f), new Vector2(0.06171665f, 0.05268952f), new Vector2(0.06932893f, 0.05708453f), new Vector2(0.5000001f, 0.9777013f), new Vector2(0.9137015f, 0.7388506f), new Vector2(0.9137015f, 0.2611492f), new Vector2(0.5000002f, 0.02229857f), new Vector2(0.08629858f, 0.7388505f), new Vector2(0.08629858f, 0.2611492f) }.ToArray(),
            new List<Vector3>() { new Vector3(-2.235174E-08f, 0.5622821f, -0.2248604f), new Vector3(-0.04864722f, 0.5622821f, -0.1967741f), new Vector3(-0.04864718f, 0.7014224f, -0.1391402f), new Vector3(1.676381E-08f, 0.7212825f, -0.1590004f), new Vector3(-0.04864722f, 0.5622821f, -0.1967741f), new Vector3(-0.04864722f, 0.5622821f, -0.1406011f), new Vector3(-0.04864718f, 0.6617022f, -0.09941996f), new Vector3(-0.04864718f, 0.7014224f, -0.1391402f), new Vector3(-0.04864717f, 0.7028832f, -1.133272E-08f), new Vector3(-0.04864717f, 0.7590562f, -1.133272E-08f), new Vector3(-0.04864717f, 0.6617022f, 0.09942f), new Vector3(-0.04864717f, 0.7014224f, 0.1391402f), new Vector3(-0.04864721f, 0.5622821f, 0.140601f), new Vector3(-0.04864718f, 0.5622821f, 0.196774f), new Vector3(-0.04864722f, 0.4628623f, 0.09942f), new Vector3(-0.04864722f, 0.4231421f, 0.1391402f), new Vector3(-0.04864722f, 0.4216811f, -1.133272E-08f), new Vector3(-0.04864722f, 0.3655082f, -4.113505E-08f), new Vector3(-0.04864722f, 0.4628622f, -0.09941993f), new Vector3(-0.04864722f, 0.4231419f, -0.1391402f), new Vector3(-0.04864722f, 0.5622821f, -0.1406011f), new Vector3(-1.490116E-08f, 0.5622821f, -0.1125146f), new Vector3(0f, 0.641842f, -0.07955981f), new Vector3(-0.04864718f, 0.6617022f, -0.09941996f), new Vector3(-1.490116E-08f, 0.5622821f, -0.1125146f), new Vector3(0.0486472f, 0.5622821f, -0.1406011f), new Vector3(0.04864722f, 0.6617022f, -0.09941996f), new Vector3(0f, 0.641842f, -0.07955981f), new Vector3(0.0486472f, 0.5622821f, -0.1406011f), new Vector3(0.04864718f, 0.5622821f, -0.1967741f), new Vector3(0.04864722f, 0.7014224f, -0.1391402f), new Vector3(0.04864722f, 0.6617022f, -0.09941996f), new Vector3(0.04864722f, 0.7590562f, -1.133272E-08f), new Vector3(0.04864722f, 0.7028832f, -1.133272E-08f), new Vector3(0.04864724f, 0.7014224f, 0.1391402f), new Vector3(0.04864722f, 0.6617022f, 0.09942f), new Vector3(0.04864722f, 0.5622821f, 0.196774f), new Vector3(0.04864722f, 0.5622821f, 0.140601f), new Vector3(0.04864721f, 0.423142f, 0.1391402f), new Vector3(0.0486472f, 0.4628623f, 0.09941994f), new Vector3(0.04864717f, 0.3655082f, -4.113505E-08f), new Vector3(0.04864718f, 0.4216811f, -7.093737E-08f), new Vector3(0.04864717f, 0.4231419f, -0.1391402f), new Vector3(0.04864718f, 0.4628622f, -0.09941993f), new Vector3(-2.235174E-08f, 0.5622821f, -0.2248604f), new Vector3(1.676381E-08f, 0.7212825f, -0.1590004f), new Vector3(0.04864722f, 0.7014224f, -0.1391402f), new Vector3(0.04864718f, 0.5622821f, -0.1967741f), new Vector3(1.676381E-08f, 0.7212825f, -0.1590004f), new Vector3(-0.04864718f, 0.7014224f, -0.1391402f), new Vector3(-0.04864717f, 0.7590562f, -1.133272E-08f), new Vector3(2.980232E-08f, 0.7871426f, -1.133272E-08f), new Vector3(-0.04864718f, 0.6617022f, -0.09941996f), new Vector3(0f, 0.641842f, -0.07955981f), new Vector3(9.313226E-09f, 0.6747968f, -1.133272E-08f), new Vector3(-0.04864717f, 0.7028832f, -1.133272E-08f), new Vector3(0f, 0.641842f, -0.07955981f), new Vector3(0.04864722f, 0.6617022f, -0.09941996f), new Vector3(0.04864722f, 0.7028832f, -1.133272E-08f), new Vector3(9.313226E-09f, 0.6747968f, -1.133272E-08f), new Vector3(0.04864722f, 0.7014224f, -0.1391402f), new Vector3(1.676381E-08f, 0.7212825f, -0.1590004f), new Vector3(2.980232E-08f, 0.7871426f, -1.133272E-08f), new Vector3(0.04864722f, 0.7590562f, -1.133272E-08f), new Vector3(2.980232E-08f, 0.7871426f, -1.133272E-08f), new Vector3(-0.04864717f, 0.7590562f, -1.133272E-08f), new Vector3(-0.04864717f, 0.7014224f, 0.1391402f), new Vector3(3.539026E-08f, 0.7212825f, 0.1590004f), new Vector3(-0.04864717f, 0.7028832f, -1.133272E-08f), new Vector3(9.313226E-09f, 0.6747968f, -1.133272E-08f), new Vector3(1.117587E-08f, 0.641842f, 0.07955986f), new Vector3(-0.04864717f, 0.6617022f, 0.09942f), new Vector3(9.313226E-09f, 0.6747968f, -1.133272E-08f), new Vector3(0.04864722f, 0.7028832f, -1.133272E-08f), new Vector3(0.04864722f, 0.6617022f, 0.09942f), new Vector3(1.117587E-08f, 0.641842f, 0.07955986f), new Vector3(0.04864722f, 0.7590562f, -1.133272E-08f), new Vector3(2.980232E-08f, 0.7871426f, -1.133272E-08f), new Vector3(3.539026E-08f, 0.7212825f, 0.1590004f), new Vector3(0.04864724f, 0.7014224f, 0.1391402f), new Vector3(3.539026E-08f, 0.7212825f, 0.1590004f), new Vector3(-0.04864717f, 0.7014224f, 0.1391402f), new Vector3(-0.04864718f, 0.5622821f, 0.196774f), new Vector3(1.676381E-08f, 0.5622821f, 0.2248604f), new Vector3(-0.04864717f, 0.6617022f, 0.09942f), new Vector3(1.117587E-08f, 0.641842f, 0.07955986f), new Vector3(5.587935E-09f, 0.5622821f, 0.1125146f), new Vector3(-0.04864721f, 0.5622821f, 0.140601f), new Vector3(1.117587E-08f, 0.641842f, 0.07955986f), new Vector3(0.04864722f, 0.6617022f, 0.09942f), new Vector3(0.04864722f, 0.5622821f, 0.140601f), new Vector3(5.587935E-09f, 0.5622821f, 0.1125146f), new Vector3(0.04864724f, 0.7014224f, 0.1391402f), new Vector3(3.539026E-08f, 0.7212825f, 0.1590004f), new Vector3(1.676381E-08f, 0.5622821f, 0.2248604f), new Vector3(0.04864722f, 0.5622821f, 0.196774f), new Vector3(1.676381E-08f, 0.5622821f, 0.2248604f), new Vector3(-0.04864718f, 0.5622821f, 0.196774f), new Vector3(-0.04864722f, 0.4231421f, 0.1391402f), new Vector3(-1.490116E-08f, 0.4032819f, 0.1590003f), new Vector3(-0.04864721f, 0.5622821f, 0.140601f), new Vector3(5.587935E-09f, 0.5622821f, 0.1125146f), new Vector3(-3.72529E-09f, 0.4827224f, 0.0795598f), new Vector3(-0.04864722f, 0.4628623f, 0.09942f), new Vector3(5.587935E-09f, 0.5622821f, 0.1125146f), new Vector3(0.04864722f, 0.5622821f, 0.140601f), new Vector3(0.0486472f, 0.4628623f, 0.09941994f), new Vector3(-3.72529E-09f, 0.4827224f, 0.0795598f), new Vector3(0.04864722f, 0.5622821f, 0.196774f), new Vector3(1.676381E-08f, 0.5622821f, 0.2248604f), new Vector3(-1.490116E-08f, 0.4032819f, 0.1590003f), new Vector3(0.04864721f, 0.423142f, 0.1391402f), new Vector3(-1.490116E-08f, 0.4032819f, 0.1590003f), new Vector3(-0.04864722f, 0.4231421f, 0.1391402f), new Vector3(-0.04864722f, 0.3655082f, -4.113505E-08f), new Vector3(-2.980232E-08f, 0.3374217f, -4.113505E-08f), new Vector3(-0.04864722f, 0.4628623f, 0.09942f), new Vector3(-3.72529E-09f, 0.4827224f, 0.0795598f), new Vector3(-1.303852E-08f, 0.4497676f, -1.133272E-08f), new Vector3(-0.04864722f, 0.4216811f, -1.133272E-08f), new Vector3(-3.72529E-09f, 0.4827224f, 0.0795598f), new Vector3(0.0486472f, 0.4628623f, 0.09941994f), new Vector3(0.04864718f, 0.4216811f, -7.093737E-08f), new Vector3(-1.303852E-08f, 0.4497676f, -1.133272E-08f), new Vector3(0.04864721f, 0.423142f, 0.1391402f), new Vector3(-1.490116E-08f, 0.4032819f, 0.1590003f), new Vector3(-2.980232E-08f, 0.3374217f, -4.113505E-08f), new Vector3(0.04864717f, 0.3655082f, -4.113505E-08f), new Vector3(-2.980232E-08f, 0.3374217f, -4.113505E-08f), new Vector3(-0.04864722f, 0.3655082f, -4.113505E-08f), new Vector3(-0.04864722f, 0.4231419f, -0.1391402f), new Vector3(-3.539026E-08f, 0.4032818f, -0.1590003f), new Vector3(-0.04864722f, 0.4216811f, -1.133272E-08f), new Vector3(-1.303852E-08f, 0.4497676f, -1.133272E-08f), new Vector3(-1.490116E-08f, 0.4827224f, -0.07955975f), new Vector3(-0.04864722f, 0.4628622f, -0.09941993f), new Vector3(-1.303852E-08f, 0.4497676f, -1.133272E-08f), new Vector3(0.04864718f, 0.4216811f, -7.093737E-08f), new Vector3(0.04864718f, 0.4628622f, -0.09941993f), new Vector3(-1.490116E-08f, 0.4827224f, -0.07955975f), new Vector3(0.04864717f, 0.3655082f, -4.113505E-08f), new Vector3(-2.980232E-08f, 0.3374217f, -4.113505E-08f), new Vector3(-3.539026E-08f, 0.4032818f, -0.1590003f), new Vector3(0.04864717f, 0.4231419f, -0.1391402f), new Vector3(-3.539026E-08f, 0.4032818f, -0.1590003f), new Vector3(-0.04864722f, 0.4231419f, -0.1391402f), new Vector3(-0.04864722f, 0.5622821f, -0.1967741f), new Vector3(-2.235174E-08f, 0.5622821f, -0.2248604f), new Vector3(-0.04864722f, 0.4628622f, -0.09941993f), new Vector3(-1.490116E-08f, 0.4827224f, -0.07955975f), new Vector3(-1.490116E-08f, 0.5622821f, -0.1125146f), new Vector3(-0.04864722f, 0.5622821f, -0.1406011f), new Vector3(-1.490116E-08f, 0.4827224f, -0.07955975f), new Vector3(0.04864718f, 0.4628622f, -0.09941993f), new Vector3(0.0486472f, 0.5622821f, -0.1406011f), new Vector3(-1.490116E-08f, 0.5622821f, -0.1125146f), new Vector3(0.04864717f, 0.4231419f, -0.1391402f), new Vector3(-3.539026E-08f, 0.4032818f, -0.1590003f), new Vector3(-2.235174E-08f, 0.5622821f, -0.2248604f), new Vector3(0.04864718f, 0.5622821f, -0.1967741f), new Vector3(0f, 0f, -0.0625f), new Vector3(-0.4330127f, 0.25f, -0.0625f), new Vector3(0f, 0.5f, -0.0625f), new Vector3(-0.4330127f, -0.25f, -0.0625f), new Vector3(4.371139E-08f, -0.5f, -0.0625f), new Vector3(0.4330127f, -0.25f, -0.0625f), new Vector3(0.4330127f, 0.25f, -0.0625f), new Vector3(0f, 0.5f, -0.0625f), new Vector3(-0.4330127f, 0.25f, -0.0625f), new Vector3(-0.4330127f, 0.25f, 0.0625f), new Vector3(0f, 0.5f, 0.0625f), new Vector3(-0.4330127f, 0.25f, -0.0625f), new Vector3(-0.4330127f, -0.25f, -0.0625f), new Vector3(-0.4330127f, -0.25f, 0.0625f), new Vector3(-0.4330127f, 0.25f, 0.0625f), new Vector3(-0.4330127f, -0.25f, -0.0625f), new Vector3(4.371139E-08f, -0.5f, -0.0625f), new Vector3(4.371139E-08f, -0.5f, 0.0625f), new Vector3(-0.4330127f, -0.25f, 0.0625f), new Vector3(4.371139E-08f, -0.5f, -0.0625f), new Vector3(0.4330127f, -0.25f, -0.0625f), new Vector3(0.4330127f, -0.25f, 0.0625f), new Vector3(4.371139E-08f, -0.5f, 0.0625f), new Vector3(0.4330127f, -0.25f, -0.0625f), new Vector3(0.4330127f, 0.25f, -0.0625f), new Vector3(0.4330127f, 0.25f, 0.0625f), new Vector3(0.4330127f, -0.25f, 0.0625f), new Vector3(0.4330127f, 0.25f, -0.0625f), new Vector3(0f, 0.5f, -0.0625f), new Vector3(0f, 0.5f, 0.0625f), new Vector3(0.4330127f, 0.25f, 0.0625f), new Vector3(-0.3464102f, 0.2f, 0.0625f), new Vector3(-0.3464102f, 0.2f, 0.1293688f), new Vector3(1.70299E-09f, 0.4f, 0.1293688f), new Vector3(1.70299E-09f, 0.4f, 0.0625f), new Vector3(-0.3464102f, -0.2f, 0.0625f), new Vector3(-0.3464102f, -0.2f, 0.1293688f), new Vector3(-0.3464102f, 0.2f, 0.1293688f), new Vector3(-0.3464102f, 0.2f, 0.0625f), new Vector3(3.66721E-08f, -0.4f, 0.0625f), new Vector3(3.66721E-08f, -0.4f, 0.1293688f), new Vector3(-0.3464102f, -0.2f, 0.1293688f), new Vector3(-0.3464102f, -0.2f, 0.0625f), new Vector3(0.3464102f, -0.2f, 0.0625f), new Vector3(0.3464102f, -0.2f, 0.1293688f), new Vector3(3.66721E-08f, -0.4f, 0.1293688f), new Vector3(3.66721E-08f, -0.4f, 0.0625f), new Vector3(0.3464102f, 0.2f, 0.0625f), new Vector3(0.3464102f, 0.2f, 0.1293688f), new Vector3(0.3464102f, -0.2f, 0.1293688f), new Vector3(0.3464102f, -0.2f, 0.0625f), new Vector3(1.70299E-09f, 0.4f, 0.0625f), new Vector3(1.70299E-09f, 0.4f, 0.1293688f), new Vector3(0.3464102f, 0.2f, 0.1293688f), new Vector3(0.3464102f, 0.2f, 0.0625f), new Vector3(-0.4330127f, 0.25f, 0.0625f), new Vector3(-0.3464102f, 0.2f, 0.0625f), new Vector3(1.70299E-09f, 0.4f, 0.0625f), new Vector3(0f, 0.5f, 0.0625f), new Vector3(-0.4330127f, -0.25f, 0.0625f), new Vector3(-0.3464102f, -0.2f, 0.0625f), new Vector3(4.371139E-08f, -0.5f, 0.0625f), new Vector3(3.66721E-08f, -0.4f, 0.0625f), new Vector3(0.4330127f, -0.25f, 0.0625f), new Vector3(0.3464102f, -0.2f, 0.0625f), new Vector3(0.4330127f, 0.25f, 0.0625f), new Vector3(0.3464102f, 0.2f, 0.0625f), new Vector3(1.70299E-09f, 0.4f, 0.1293688f), new Vector3(1.260392E-08f, 0.2374878f, 0.1293688f), new Vector3(0.2056705f, 0.1187439f, 0.1293688f), new Vector3(0.3464102f, 0.2f, 0.1293688f), new Vector3(0.2056705f, -0.1187439f, 0.1293688f), new Vector3(0.3464102f, -0.2f, 0.1293688f), new Vector3(3.336577E-08f, -0.2374878f, 0.1293688f), new Vector3(3.66721E-08f, -0.4f, 0.1293688f), new Vector3(-0.2056704f, -0.1187439f, 0.1293688f), new Vector3(-0.3464102f, -0.2f, 0.1293688f), new Vector3(-0.2056705f, 0.1187439f, 0.1293688f), new Vector3(-0.3464102f, 0.2f, 0.1293688f), new Vector3(1.260392E-08f, 0.2374878f, 0.1293688f), new Vector3(-0.2056705f, 0.1187439f, 0.1293688f), new Vector3(-0.2056704f, -0.1187439f, 0.1293688f), new Vector3(3.336577E-08f, -0.2374878f, 0.1293688f), new Vector3(0.2056705f, 0.1187439f, 0.1293688f), new Vector3(0.2056705f, -0.1187439f, 0.1293688f) }.ToArray()
        );


        public static Mesh CreateMesh(MeshInfo meshInfo) {
            Mesh mesh = new Mesh();
            mesh.vertices = meshInfo.vertices;
            mesh.uv = meshInfo.uvs;
            mesh.normals = meshInfo.normals;
            mesh.triangles = meshInfo.triangles;
            return mesh;
        }

    }
}
