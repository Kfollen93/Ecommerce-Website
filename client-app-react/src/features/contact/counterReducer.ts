export interface CounterState {
    data: number;
    title: string;
}

const initialState: CounterState = {
    data: 35,
    title: 'Testing counter'
}

export default function counterReducer(state = initialState, action: any) {
    return state;
}