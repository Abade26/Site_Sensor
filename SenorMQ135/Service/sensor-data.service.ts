/*import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface SensorData {
    id: number;
    timestamp: Date;
    value: number;
}

@Injectable({
    providedIn: 'root'
})
export class SensorDataService {
    private apiUrl = 'https://localhost:5001/sensordata'; // URL da sua API

    constructor(private http: HttpClient) { }

    postSensorData(data: SensorData): Observable<SensorData> {
        return this.http.post<SensorData>(this.apiUrl, data);
    }
}*/
