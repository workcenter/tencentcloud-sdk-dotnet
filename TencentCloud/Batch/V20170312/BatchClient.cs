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

namespace TencentCloud.Batch.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Batch.V20170312.Models;

   public class BatchClient : AbstractClient{

       private const string endpoint = "batch.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public BatchClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public BatchClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用于创建计算环境
        /// </summary>
        /// <param name="req">参考<see cref="CreateComputeEnvRequest"/></param>
        /// <returns>参考<see cref="CreateComputeEnvResponse"/>实例</returns>
        public async Task<CreateComputeEnvResponse> CreateComputeEnv(CreateComputeEnvRequest req)
        {
             JsonResponseModel<CreateComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建任务模板
        /// </summary>
        /// <param name="req">参考<see cref="CreateTaskTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateTaskTemplateResponse"/>实例</returns>
        public async Task<CreateTaskTemplateResponse> CreateTaskTemplate(CreateTaskTemplateRequest req)
        {
             JsonResponseModel<CreateTaskTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTaskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除计算环境
        /// </summary>
        /// <param name="req">参考<see cref="DeleteComputeEnvRequest"/></param>
        /// <returns>参考<see cref="DeleteComputeEnvResponse"/>实例</returns>
        public async Task<DeleteComputeEnvResponse> DeleteComputeEnv(DeleteComputeEnvRequest req)
        {
             JsonResponseModel<DeleteComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除作业记录。
        /// 删除作业的效果相当于删除作业相关的所有信息。删除成功后，作业相关的所有信息都无法查询。
        /// 待删除的作业必须处于完结状态，且其内部包含的所有任务实例也必须处于完结状态，否则会禁止操作。完结状态，是指处于 SUCCEED 或 FAILED 状态。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteJobRequest"/></param>
        /// <returns>参考<see cref="DeleteJobResponse"/>实例</returns>
        public async Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
             JsonResponseModel<DeleteJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除任务模板信息
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTaskTemplatesRequest"/></param>
        /// <returns>参考<see cref="DeleteTaskTemplatesResponse"/>实例</returns>
        public async Task<DeleteTaskTemplatesResponse> DeleteTaskTemplates(DeleteTaskTemplatesRequest req)
        {
             JsonResponseModel<DeleteTaskTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTaskTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看可用的CVM机型配置信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns>参考<see cref="DescribeAvailableCvmInstanceTypesResponse"/>实例</returns>
        public async Task<DescribeAvailableCvmInstanceTypesResponse> DescribeAvailableCvmInstanceTypes(DescribeAvailableCvmInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableCvmInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询计算环境的详细信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComputeEnvRequest"/></param>
        /// <returns>参考<see cref="DescribeComputeEnvResponse"/>实例</returns>
        public async Task<DescribeComputeEnvResponse> DescribeComputeEnv(DescribeComputeEnvRequest req)
        {
             JsonResponseModel<DescribeComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询计算环境的活动信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComputeEnvActivitiesRequest"/></param>
        /// <returns>参考<see cref="DescribeComputeEnvActivitiesResponse"/>实例</returns>
        public async Task<DescribeComputeEnvActivitiesResponse> DescribeComputeEnvActivities(DescribeComputeEnvActivitiesRequest req)
        {
             JsonResponseModel<DescribeComputeEnvActivitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看计算环境的创建信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComputeEnvCreateInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeComputeEnvCreateInfoResponse"/>实例</returns>
        public async Task<DescribeComputeEnvCreateInfoResponse> DescribeComputeEnvCreateInfo(DescribeComputeEnvCreateInfoRequest req)
        {
             JsonResponseModel<DescribeComputeEnvCreateInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvCreateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvCreateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看计算环境创建信息列表，包括名称、描述、类型、环境参数、通知及期望节点数等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComputeEnvCreateInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeComputeEnvCreateInfosResponse"/>实例</returns>
        public async Task<DescribeComputeEnvCreateInfosResponse> DescribeComputeEnvCreateInfos(DescribeComputeEnvCreateInfosRequest req)
        {
             JsonResponseModel<DescribeComputeEnvCreateInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvCreateInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvCreateInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看计算环境列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeComputeEnvsRequest"/></param>
        /// <returns>参考<see cref="DescribeComputeEnvsResponse"/>实例</returns>
        public async Task<DescribeComputeEnvsResponse> DescribeComputeEnvs(DescribeComputeEnvsRequest req)
        {
             JsonResponseModel<DescribeComputeEnvsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取批量计算可用区机型配置信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeCvmZoneInstanceConfigInfosResponse"/>实例</returns>
        public async Task<DescribeCvmZoneInstanceConfigInfosResponse> DescribeCvmZoneInstanceConfigInfos(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCvmZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看一个作业的详细信息，包括内部任务（Task）和依赖（Dependence）信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeJobRequest"/></param>
        /// <returns>参考<see cref="DescribeJobResponse"/>实例</returns>
        public async Task<DescribeJobResponse> DescribeJob(DescribeJobRequest req)
        {
             JsonResponseModel<DescribeJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询指定作业的提交信息，其返回内容包括 JobId 和 SubmitJob 接口中作为输入参数的作业提交信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeJobSubmitInfoResponse"/>实例</returns>
        public async Task<DescribeJobSubmitInfoResponse> DescribeJobSubmitInfo(DescribeJobSubmitInfoRequest req)
        {
             JsonResponseModel<DescribeJobSubmitInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobSubmitInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobSubmitInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询若干个作业的概览信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeJobsRequest"/></param>
        /// <returns>参考<see cref="DescribeJobsResponse"/>实例</returns>
        public async Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
             JsonResponseModel<DescribeJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询指定任务的详细信息，包括任务内部的任务实例信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskResponse"/>实例</returns>
        public async Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取任务多个实例标准输出和标准错误日志。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskLogsResponse"/>实例</returns>
        public async Task<DescribeTaskLogsResponse> DescribeTaskLogs(DescribeTaskLogsRequest req)
        {
             JsonResponseModel<DescribeTaskLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询任务模板信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskTemplatesResponse"/>实例</returns>
        public async Task<DescribeTaskTemplatesResponse> DescribeTaskTemplates(DescribeTaskTemplatesRequest req)
        {
             JsonResponseModel<DescribeTaskTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改计算环境属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifyComputeEnvRequest"/></param>
        /// <returns>参考<see cref="ModifyComputeEnvResponse"/>实例</returns>
        public async Task<ModifyComputeEnvResponse> ModifyComputeEnv(ModifyComputeEnvRequest req)
        {
             JsonResponseModel<ModifyComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改任务模板
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTaskTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyTaskTemplateResponse"/>实例</returns>
        public async Task<ModifyTaskTemplateResponse> ModifyTaskTemplate(ModifyTaskTemplateRequest req)
        {
             JsonResponseModel<ModifyTaskTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于重试作业中失败的任务实例。
        /// 当且仅当作业处于“FAILED”状态，支持重试操作。重试操作成功后，作业会按照“DAG”中指定的任务依赖关系，依次重试各个任务中失败的任务实例。任务实例的历史信息将被重置，如同首次运行一样，参与后续的调度和执行。
        /// </summary>
        /// <param name="req">参考<see cref="RetryJobsRequest"/></param>
        /// <returns>参考<see cref="RetryJobsResponse"/>实例</returns>
        public async Task<RetryJobsResponse> RetryJobs(RetryJobsRequest req)
        {
             JsonResponseModel<RetryJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RetryJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于提交一个作业
        /// </summary>
        /// <param name="req">参考<see cref="SubmitJobRequest"/></param>
        /// <returns>参考<see cref="SubmitJobResponse"/>实例</returns>
        public async Task<SubmitJobResponse> SubmitJob(SubmitJobRequest req)
        {
             JsonResponseModel<SubmitJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于销毁计算节点。
        /// 对于状态为CREATED、CREATION_FAILED、RUNNING和ABNORMAL的节点，允许销毁处理。
        /// </summary>
        /// <param name="req">参考<see cref="TerminateComputeNodeRequest"/></param>
        /// <returns>参考<see cref="TerminateComputeNodeResponse"/>实例</returns>
        public async Task<TerminateComputeNodeResponse> TerminateComputeNode(TerminateComputeNodeRequest req)
        {
             JsonResponseModel<TerminateComputeNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateComputeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateComputeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量销毁计算节点，不允许重复销毁同一个节点。
        /// </summary>
        /// <param name="req">参考<see cref="TerminateComputeNodesRequest"/></param>
        /// <returns>参考<see cref="TerminateComputeNodesResponse"/>实例</returns>
        public async Task<TerminateComputeNodesResponse> TerminateComputeNodes(TerminateComputeNodesRequest req)
        {
             JsonResponseModel<TerminateComputeNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateComputeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateComputeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于终止作业。
        /// 当作业处于“SUBMITTED”状态时，禁止终止操作；当作业处于“SUCCEED”状态时，终止操作不会生效。
        /// 终止作业是一个异步过程。整个终止过程的耗时和任务总数成正比。终止的效果相当于所含的所有任务实例进行TerminateTaskInstance操作。具体效果和用法可参考TerminateTaskInstance。
        /// </summary>
        /// <param name="req">参考<see cref="TerminateJobRequest"/></param>
        /// <returns>参考<see cref="TerminateJobResponse"/>实例</returns>
        public async Task<TerminateJobResponse> TerminateJob(TerminateJobRequest req)
        {
             JsonResponseModel<TerminateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于终止任务实例。
        /// 对于状态已经为“SUCCEED”和“FAILED”的任务实例，不做处理。
        /// 对于状态为“SUBMITTED”、“PENDING”、“RUNNABLE”的任务实例，状态将置为“FAILED”状态。
        /// 对于状态为“STARTING”、“RUNNING”、“FAILED_INTERRUPTED”的任务实例，分区两种情况：如果未显示指定计算环境，会先销毁CVM服务器，然后将状态置为“FAILED”，具有一定耗时；如果指定了计算环境EnvId，任务实例状态置为“FAILED”，并重启执行该任务的CVM服务器，具有一定的耗时。
        /// 对于状态为“FAILED_INTERRUPTED”的任务实例，终止操作实际成功之后，相关资源和配额才会释放。
        /// </summary>
        /// <param name="req">参考<see cref="TerminateTaskInstanceRequest"/></param>
        /// <returns>参考<see cref="TerminateTaskInstanceResponse"/>实例</returns>
        public async Task<TerminateTaskInstanceResponse> TerminateTaskInstance(TerminateTaskInstanceRequest req)
        {
             JsonResponseModel<TerminateTaskInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateTaskInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTaskInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
