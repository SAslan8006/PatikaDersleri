import mongoose from 'mongoose'

const userSchema = mongoose.Schema({
    fullname: {
        type: String,
        required: true
    },
    email: {
        type: String,
        required: true
    },
    password: {
        type: String,
        required: true
    },
    userType: {
        type: String,
        enum: ['USER', 'ADMIN'],
        default: 'USER'
    },
    phoneNumber: {
        type: String,
        required: true
    },
})

export default mongoose.model('User', userSchema)