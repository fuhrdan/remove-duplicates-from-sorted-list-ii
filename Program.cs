//*****************************************************************************
//** 82. Remove Duplicates from Sorted List II                      leetcode **
//*****************************************************************************

/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* deleteDuplicates(struct ListNode* head) {
    struct ListNode* dummy = (struct ListNode*)malloc(sizeof(struct ListNode));
    struct ListNode* pre;
    struct ListNode* cur;

    dummy->val = 0;
    dummy->next = head;

    pre = dummy;
    cur = head;

    while (cur)
    {
        while (cur->next && cur->next->val == cur->val)
        {
            cur = cur->next;
        }

        if (pre->next == cur)
        {
            pre = cur;
        }
        else
        {
            pre->next = cur->next;
        }

        cur = cur->next;
    }

    head = dummy->next;
    free(dummy);

    return head;
}