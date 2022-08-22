using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Shared.Constants
{
    public static class QueueConstants
    {
        public const string HouseKeeping = "HouseKeepingName";//housekeeping_queue_mspod12_hieunguyen
        public const string UnlockEngagementQueue = "UnlockEngagementQueueName";//unlockengagement_queue__mspod12_hieunguyen
        public const string Subscription = "SubscriptionName";//spoprocess_sub_hieunguyen
        public const string Topic = "TopicName";//spoprocess_topic_mspod12
        public const string WpGenerationQueue = "WpGenerationQueueName";//wp_generation_queue_mspod12_hieunguyen
        public const string Queue = "QueueName";//spoprocess_queue_mspod12_hieunguyen
        public const string FileCheckQueue = "FileCheckQueueName";//integritycheckprocessor_queue_mspod12_hieunguyen //filecheckprocessor_queue_mspod12_hieunguyen

        #region [Copy]
        public const string DuplicateEngQueue = "DuplicateEngQueueName";//duplicateengqueue_mspod12_hieunguyen
        public const string DuplicateFileQueue = "DuplicateFileQueueName";//duplicatefilequeue_mspod12_hieunguyen
        #endregion

        #region [Archive]
        public const string ArchiveQueue = "ArchiveQueueName";//archiveprocessor_queue_mspod12_hieunguyen
        #endregion

        #region [CF]
        public const string CarryforwardQueue = "CarryforwardQueueName";//carryforward_queue_mspod12_hieunguyen
        public const string CopyFileTransferQueue = "CopyFileTransferQueueName";//carryforward_filetransfer_queue_mspod12_hieunguyen
        public const string ContentQueue = "ContentQueueName";//carryforward_content_queue_mspod12_hieunguyen
        public const string CopyEngQueue = "CopyEngQueueName";//carryforward_copy_eng_queue_mspod12_hieunguyen
        #endregion

       

    }
}
