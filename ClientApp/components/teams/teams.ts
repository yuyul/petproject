import Vue from 'vue';
import { Component } from 'vue-property-decorator';

@Component
export default class TeamsComponent extends Vue {
    teams: String[] = [];

    mounted() {
        fetch('api/Team/Get')
            .then(response => response.json() as Promise<String[]>)
            .then(data => {
                this.teams = data;
            });
    }
}