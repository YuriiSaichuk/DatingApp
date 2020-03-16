export interface Message {
    id: number;
    senderId: number;
    recipientId: number;
    isRead: boolean;
    content: string;
    senderUsername: string;
    recipientUsername: string;
    senderPhotoUrl: string;
    recipientPhotoUrl: string;
    dateRead: Date;
    messageSent: Date;
}
