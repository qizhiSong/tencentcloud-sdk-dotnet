/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Iai.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iai.V20180301.Models;

   public class IaiClient : AbstractClient{

       private const string endpoint = "iai.tencentcloudapi.com";
       private const string version = "2018-03-01";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public IaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public IaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 对请求图片进行五官定位（也称人脸关键点定位），计算构成人脸轮廓的 90 个点，包括眉毛（左右各 8 点）、眼睛（左右各 8 点）、鼻子（13 点）、嘴巴（22 点）、脸型轮廓（21 点）、眼珠[或瞳孔]（2点）。
        /// </summary>
        /// <param name="req">参考<see cref="AnalyzeFaceRequest"/></param>
        /// <returns>参考<see cref="AnalyzeFaceResponse"/>实例</returns>
        public async Task<AnalyzeFaceResponse> AnalyzeFace(AnalyzeFaceRequest req)
        {
             JsonResponseModel<AnalyzeFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AnalyzeFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对两张图片中的人脸进行相似度比对，返回人脸相似度分数。
        /// 
        /// 若您需要判断 “此人是否是某人”，即验证某张图片中的人是否是已知身份的某人，如常见的人脸登录场景，建议使用[人脸验证](https://cloud.tencent.com/document/product/867/32806)接口。
        /// 
        /// 若您需要判断图片中人脸的具体身份信息，如是否是身份证上对应的人，建议使用[人脸核身·云智慧眼](https://cloud.tencent.com/product/facein)产品。
        /// </summary>
        /// <param name="req">参考<see cref="CompareFaceRequest"/></param>
        /// <returns>参考<see cref="CompareFaceResponse"/>实例</returns>
        public async Task<CompareFaceResponse> CompareFace(CompareFaceRequest req)
        {
             JsonResponseModel<CompareFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompareFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将已存在于某人员库的人员复制到其他人员库，该人员的描述信息不会被复制。单个人员最多只能同时存在100个人员库中。
        /// </summary>
        /// <param name="req">参考<see cref="CopyPersonRequest"/></param>
        /// <returns>参考<see cref="CopyPersonResponse"/>实例</returns>
        public async Task<CopyPersonResponse> CopyPerson(CopyPersonRequest req)
        {
             JsonResponseModel<CopyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将一组人脸图片添加到一个人员中。一个人员最多允许包含 5 张图片。若该人员存在多个人员库中，所有人员库中该人员图片均会增加。
        /// >
        /// - 增加人脸完成后，生效时间一般不超过 1 秒，极端情况最多不超过 5 秒，之后您可以进行[人脸搜索](https://cloud.tencent.com/document/product/867/32798)或[人脸验证](https://cloud.tencent.com/document/product/867/32806)。
        /// </summary>
        /// <param name="req">参考<see cref="CreateFaceRequest"/></param>
        /// <returns>参考<see cref="CreateFaceResponse"/>实例</returns>
        public async Task<CreateFaceResponse> CreateFace(CreateFaceRequest req)
        {
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建一个空的人员库，如果人员库已存在返回错误。可根据需要创建自定义描述字段，用于辅助描述该人员库下的人员信息。1个APPID下最多创建2万个人员库（Group）、最多包含1000万张人脸（Face），单个人员库（Group）最多包含100万张人脸（Face）。
        /// </summary>
        /// <param name="req">参考<see cref="CreateGroupRequest"/></param>
        /// <returns>参考<see cref="CreateGroupResponse"/>实例</returns>
        public async Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建人员，添加人脸、姓名、性别及其他相关信息。
        /// >
        /// - 创建人员完成后，生效时间一般不超过 1 秒，极端情况最多不超过 5 秒，之后您可以进行[人脸搜索](https://cloud.tencent.com/document/product/867/32798)或[人脸验证](https://cloud.tencent.com/document/product/867/32806)。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePersonRequest"/></param>
        /// <returns>参考<see cref="CreatePersonResponse"/>实例</returns>
        public async Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个人员下的人脸图片。如果该人员只有一张人脸图片，则返回错误。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFaceRequest"/></param>
        /// <returns>参考<see cref="DeleteFaceResponse"/>实例</returns>
        public async Task<DeleteFaceResponse> DeleteFace(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员库及包含的所有的人员。同时，人员对应的所有人脸信息将被删除。若某人员同时存在多个人员库中，该人员不会被删除，但属于该人员库中的自定义描述字段信息会被删除。
        /// 
        /// 注：删除人员库的操作为异步执行，删除单张人脸时间约为10ms，即一小时内可以删除36万张。删除期间，无法向该人员库添加人员。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteGroupResponse"/>实例</returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员信息，此操作会导致所有人员库均删除此人员。同时，该人员的所有人脸信息将被删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonRequest"/></param>
        /// <returns>参考<see cref="DeletePersonResponse"/>实例</returns>
        public async Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从某人员库中删除人员，此操作仅影响该人员库。若该人员仅存在于指定的人员库中，该人员将被删除，其所有的人脸信息也将被删除。
        /// </summary>
        /// <param name="req">参考<see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns>参考<see cref="DeletePersonFromGroupResponse"/>实例</returns>
        public async Task<DeletePersonFromGroupResponse> DeletePersonFromGroup(DeletePersonFromGroupRequest req)
        {
             JsonResponseModel<DeletePersonFromGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测给定图片中的人脸（Face）的位置、相应的面部属性和人脸质量信息，位置包括 (x，y，w，h)，面部属性包括性别（gender）、年龄（age）、表情（expression）、魅力（beauty）、眼镜（glass）、发型（hair）、口罩（mask）和姿态 (pitch，roll，yaw)，人脸质量信息包括整体质量分（score）、模糊分（sharpness）、光照分（brightness）和五官遮挡分（completeness）。
        /// 
        ///  
        /// 其中，人脸质量信息主要用于评价输入的人脸图片的质量。在使用人脸识别服务时，建议您对输入的人脸图片进行质量检测，提升后续业务处理的效果。该功能的应用场景包括：
        /// 
        /// 1） 人员库[创建人员](https://cloud.tencent.com/document/product/867/32793)/[增加人脸](https://cloud.tencent.com/document/product/867/32795)：保证人员人脸信息的质量，便于后续的业务处理。
        /// 
        /// 2） [人脸搜索](https://cloud.tencent.com/document/product/867/32798)：保证输入的图片质量，快速准确匹配到对应的人员。
        /// 
        /// 3） [人脸验证](https://cloud.tencent.com/document/product/867/32806)：保证人脸信息的质量，避免明明是本人却认证不通过的情况。
        /// 
        /// 4） [人脸融合](https://cloud.tencent.com/product/facefusion)：保证上传的人脸质量，人脸融合的效果更好。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="DetectFaceRequest"/></param>
        /// <returns>参考<see cref="DetectFaceResponse"/>实例</returns>
        public async Task<DetectFaceResponse> DetectFace(DetectFaceRequest req)
        {
             JsonResponseModel<DetectFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对用户上传的静态图片进行人脸活体检测。与动态活体检测的区别是：静态活体检测中，用户不需要通过唇语或摇头眨眼等动作来识别。
        /// 
        /// 静态活体检测适用于手机自拍的场景，或对防攻击要求不高的场景。如果对活体检测有更高安全性要求，请使用[人脸核身·云智慧眼](https://cloud.tencent.com/product/faceid)产品。
        /// 
        /// >     
        /// - 图片的宽高比请接近3：4，不符合宽高比的图片返回的分值不具备参考意义。本接口适用于类手机自拍场景，非类手机自拍照返回的分值不具备参考意义。
        /// </summary>
        /// <param name="req">参考<see cref="DetectLiveFaceRequest"/></param>
        /// <returns>参考<see cref="DetectLiveFaceResponse"/>实例</returns>
        public async Task<DetectLiveFaceResponse> DetectLiveFace(DetectLiveFaceRequest req)
        {
             JsonResponseModel<DetectLiveFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectLiveFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库列表。
        /// </summary>
        /// <param name="req">参考<see cref="GetGroupListRequest"/></param>
        /// <returns>参考<see cref="GetGroupListResponse"/>实例</returns>
        public async Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括姓名、性别、人脸等。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns>参考<see cref="GetPersonBaseInfoResponse"/>实例</returns>
        public async Task<GetPersonBaseInfoResponse> GetPersonBaseInfo(GetPersonBaseInfoRequest req)
        {
             JsonResponseModel<GetPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括加入的人员库、描述内容等。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns>参考<see cref="GetPersonGroupInfoResponse"/>实例</returns>
        public async Task<GetPersonGroupInfoResponse> GetPersonGroupInfo(GetPersonGroupInfoRequest req)
        {
             JsonResponseModel<GetPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中的人员列表。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonListRequest"/></param>
        /// <returns>参考<see cref="GetPersonListResponse"/>实例</returns>
        public async Task<GetPersonListResponse> GetPersonList(GetPersonListRequest req)
        {
             JsonResponseModel<GetPersonListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中人员数量。
        /// </summary>
        /// <param name="req">参考<see cref="GetPersonListNumRequest"/></param>
        /// <returns>参考<see cref="GetPersonListNumResponse"/>实例</returns>
        public async Task<GetPersonListNumResponse> GetPersonListNum(GetPersonListNumRequest req)
        {
             JsonResponseModel<GetPersonListNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonListNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员库名称、备注、自定义描述字段名称。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyGroupRequest"/></param>
        /// <returns>参考<see cref="ModifyGroupResponse"/>实例</returns>
        public async Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
             JsonResponseModel<ModifyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员信息，包括名称、性别等。人员名称和性别修改会同步到包含该人员的所有人员库。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonBaseInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonBaseInfoResponse"/>实例</returns>
        public async Task<ModifyPersonBaseInfoResponse> ModifyPersonBaseInfo(ModifyPersonBaseInfoRequest req)
        {
             JsonResponseModel<ModifyPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定人员库人员描述内容。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns>参考<see cref="ModifyPersonGroupInfoResponse"/>实例</returns>
        public async Task<ModifyPersonGroupInfoResponse> ModifyPersonGroupInfo(ModifyPersonGroupInfoRequest req)
        {
             JsonResponseModel<ModifyPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopN 人员，识别结果按照相似度从大到小排序。单次搜索的人员库人脸总数量不得超过 100 万张。
        /// 此接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)结合使用。
        /// </summary>
        /// <param name="req">参考<see cref="SearchFacesRequest"/></param>
        /// <returns>参考<see cref="SearchFacesResponse"/>实例</returns>
        public async Task<SearchFacesResponse> SearchFaces(SearchFacesRequest req)
        {
             JsonResponseModel<SearchFacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/32794)。 和[人脸比对](https://cloud.tencent.com/document/product/867/32802)接口不同的是，[人脸验证](https://cloud.tencent.com/document/product/867/32806)用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而[人脸比对](https://cloud.tencent.com/document/product/867/32802)用于判断两张人脸的相似度。
        /// </summary>
        /// <param name="req">参考<see cref="VerifyFaceRequest"/></param>
        /// <returns>参考<see cref="VerifyFaceResponse"/>实例</returns>
        public async Task<VerifyFaceResponse> VerifyFace(VerifyFaceRequest req)
        {
             JsonResponseModel<VerifyFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
