export default function reducers(state, action) {
    switch (action.type) {
        case 'ADD_FAV_JOB':
            const { detail } = action.payload;
            if (state.favJobList.find(item => item.id === detail.id)) {
                return state
            }

            const newFavJob = [detail, ...state.favJobList]
            return { ...state, favJobList: newFavJob };

        case 'REMOVE_FAV_JOB':
            const { id } = action.payload
            const newFavJobList = state.favJobList.filter(item => item.id !== id)
            return { ...state, favJobList: newFavJobList }

        case 'ADD_SUBMIT_JOB':
            const { detail: submitJob } = action.payload;
            if (state.submitJobList.find(item => item.id === submitJob.id)) {
                return state
            }

            const newSubmitJob = [submitJob, ...state.submitJobList]
            return { ...state, submitJobList: newSubmitJob };


        default:
            return state
    }
}